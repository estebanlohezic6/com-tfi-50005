using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TFI_Comunicaciones.Entidades;
using TFI_Comunicaciones.Graficadores;

namespace TFI_Comunicaciones
{
    #region Explicación
    //VistaModulacion
    //Este formulario es la principal interfaz del sistema.
    //Donde se presenta toda la información y realiza el registro de eventos de usuario.
    #endregion
    public partial class VistaModulacion : Form
    {
        public VistaModulacion()
        {
            InitializeComponent();
            //Al comenzar, el sistema coloca en la grid de símbolos un 0 y 1.
            ActualizarGridSimbolos(new List<string> { "0", "1" });
            //Se crea una nueva señal cuyos datos se enlazan a la vista.
            bsSenal.DataSource = new Senal();
            //Se crea un nuevo código binario cuyos datos se enlazan a la vista
            bsCodBinario.DataSource = new CodBinario();
            //Se coloca en el box de tipoGrafica los distintos tipos.
            foreach(var item in Enum.GetValues(typeof(tipoGrafica)))
            {
                cboxGrafica.Items.Add(item.ToString());
            }
        }

        #region Eventos
        //Evento para cambiar el número de cifras por símbolo.
        private void numDigSimb_ValueChanged(object sender, EventArgs e)
        {
            int NASK;
            //Actualiza la Label N-ASK de acuerdo al número de cifras/símbolo
            if (numDigSimb.Value <= 1) { lblNASK.Text = "ASK"; }
            else
            {
                NASK = (int)(Math.Pow(2, (int)(numDigSimb.Value)));
                lblNASK.Text = NASK.ToString() + "-ASK";
            }
            //Actualiza la tabla de verdad con los símbolos posibles.
            List<string> combinacionesBinarias = IniciarGeneracionBinarios((int) (numDigSimb.Value));
            ActualizarGridSimbolos(combinacionesBinarias);
            //Actualiza los datos asociados al código binario : símbolos y duración.
            ActualizarCodBinario();
        }

        //Evento para filtrar la entrada en el campo de código binario
        private void txtBinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si la tecla presionada en el campo de texto binario no es '0' , '1' , o de control, no escribe nada. 
            if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar)) { e.Handled = true; }
        }

        //Evento para manejar cambios en el codigo binario.
        private void txtBinario_TextChanged(object sender, EventArgs e)
        {
            ActualizarCodBinario();
        }

        //Evento para actualizar los valores asociados a código binario.
        private void ActualizarCodBinario()
        {
            //Crear un nuevo código.
            CodBinario newCode = new CodBinario();
            //Establecer la cadena de este código a lo que haya escrito en el campo de texto.
            newCode.Cadena = txtBinario.Text;
            //Si se comprueba que no hay datos irregulares, calcula las propiedades del código binario.
            if (ComprobarDatos()) newCode.calcularDuracion((int)(numDigSimb.Value), double.Parse(txtPeriodoSimb.Text));
            //Establece como nueva fuente de datos al código creado
            bsCodBinario.DataSource = newCode;
        }

        //Evento para comenzar el proceso de crear la gráfica.
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            //Extraer de la fuente de datos el código y la señal
            CodBinario evaluarCodigo = bsCodBinario.DataSource as CodBinario;
            Senal evaluarSenal = bsSenal.DataSource as Senal;
            //Crear una lista de valores donde guardar los datos de tabla
            List<ValorSimb> valorSimb = new List<ValorSimb>();
            //Obtener el método de modulación desde el selector
            string metodModulacion = cboxModulacion.Text;
            //Buscar el tipo de gráfica a realizar
            tipoGrafica tipo = GenerarTipoGrafica();

            //Si se comprueba que no hay datos irregulares en la tabla o en los campos.
            if (ComprobarGrid())
            {
                if (ComprobarDatos())
                {
                    //Extraer los valores para cada símbolo de la tabla.
                    foreach (DataGridViewRow r in gridSimbolos.Rows)
                    {
                        string simbolo = r.Cells[0].Value.ToString();
                        double amplitud = double.Parse(r.Cells[1].Value.ToString());
                        valorSimb.Add(new ValorSimb(simbolo, amplitud));
                    }
                    //Dibujar la gráfica con los datos dispuestos.
                    Bitmap imagen = GraficadorCoordenadas.DibujarGrafica(
                        drawSpace.Width,
                        drawSpace.Height,
                        evaluarCodigo,
                        evaluarSenal,
                        valorSimb,
                        metodModulacion,
                        tipo
                        );
                    //Establecer la imagen en el espacio de dibujo.
                    drawSpace.Image = imagen;
                } else { ErrorDatos(); } //Si encontró algun error en los datos.
            } else { ErrorAmplitudes(); } //Si encontró algun error en los datos de tabla.
        }
        #endregion

        #region Funciones Utilizadas
        private bool ComprobarGrid()
        {
            //Comprueba si alguna celda en la tabla contiene un dato que no
            //pueda traducirse a un Double.
            //Devuelve true si la comprobación fue correcta, o false si hay un dato irregular.
            bool resultado = true;
            double disposable = 0;
            try
            {
                foreach (DataGridViewRow r in gridSimbolos.Rows)
                {
                    resultado = Double.TryParse(r.Cells[1].Value.ToString(), out disposable);
                    if (disposable < 0) resultado = false;
                    if (resultado == false) { break; }
                }
            } catch (Exception ex)
            {
                return false;
            }
            return resultado;
        }
        private bool ComprobarDatos()
        {
            //Comprueba si alguno de los campos de texto contiene un dato no válido.
            //Devuelve true si la comprobación fue correcta, o false si hay un dato irregular.
            try
            {
                double baudios,frecuencia,pbit,psimb;
                baudios = double.Parse(txtBaudios.Text);
                frecuencia = double.Parse(txtFrecuencia.Text);
                pbit = double.Parse(txtPeriodoBit.Text);
                psimb = double.Parse(txtPeriodoSimb.Text);
                if(baudios<=0 || frecuencia <=0 || pbit <=0 || psimb <=0)
                {
                    throw new Exception();
                }
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        private void ActualizarGridSimbolos(List<string> listaSimb)
        {
            //Coloca la lista de símbolos enviada en la tabla de símbolos.
            //Para esto elimina los datos anteriormente escritos en la tabla.
            gridSimbolos.Rows.Clear();
            foreach (string s in listaSimb)
            { gridSimbolos.Rows.Add(s, "0.0"); }
            gridSimbolos.Refresh();
        }
        public List<string> IniciarGeneracionBinarios(int cifras)
        {
            //Inicia la generación de combinaciones binarias posibles con un número de cifras.
            List<string> combinaciones = new List<string>();
            GenerarCombinacionesBinarias(cifras, "", combinaciones);
            return combinaciones;
        }
        public void GenerarCombinacionesBinarias(int cifrasRestantes, string cadena, List<string> combinaciones)
        {
            //Función recursiva para crear las combinaciones binarias.
            if (cifrasRestantes == 0)
            {
                combinaciones.Add(cadena);
                return;
            }
            GenerarCombinacionesBinarias(cifrasRestantes - 1, cadena + "0", combinaciones);
            GenerarCombinacionesBinarias(cifrasRestantes - 1, cadena + "1", combinaciones);
        }
        public tipoGrafica GenerarTipoGrafica()
        {
            //Función para generar el tipo de gráfica desde el item seleccionado en vista.
            tipoGrafica tipo = tipoGrafica.Portadora;
            switch (cboxGrafica.Text)
            {
                case "Modulada":
                    tipo = tipoGrafica.Modulada;
                    break;
                case "Moduladora":
                    tipo = tipoGrafica.Moduladora;
                    break;
                case "Portadora":
                    tipo = tipoGrafica.Portadora;
                    break;
            }
            return tipo;
        }
        public void ErrorDatos()
        {
            //Función para crear un cuadro de diálogo de error en caso que uno o más datos no sean válidos.
            MessageBox.Show("Uno o más datos ingresados no son válidos.",
                "ERROR AL INGRESAR DATOS",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        public void ErrorAmplitudes()
        {
            //Funcion para crear un cuadro de diálogo de error en caso de que uno o más valores ingresados en la tabla no sean válidos.
            MessageBox.Show("Uno o más valores de símbolo ingresados no son válidas.",
                "ERROR AL INGRESAR VALORES DE SÍMBOLO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        #endregion
    }
}
