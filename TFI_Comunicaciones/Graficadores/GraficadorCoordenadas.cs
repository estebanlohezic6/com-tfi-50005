using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using TFI_Comunicaciones.Entidades;

namespace TFI_Comunicaciones.Graficadores
{
    public static class GraficadorCoordenadas
    {
        #region Explicación
        //GraficadorCoordenadas
        //Esta clase estática hace lo que el nombre sugiere, recibiendo información de la vista
        //que incluye todos los datos ingresados y calculados para realizar la gráfica.
        //Se responsabiliza de graficar el sistema de coordenadas en el espacio de dibujo y
        //enviar los datos al graficador de la modulación elegida para que este realize
        //el dibujo de la señal.
        #endregion
        public static Bitmap DibujarGrafica(int ancho, int altura,
                                                CodBinario codigoG,
                                                Senal senalG,
                                                List<ValorSimb> simbolosG,
                                                string modulacion,
                                                tipoGrafica tipo)
        {
            //Creo una nueva imagen, con el ancho y altura del espacio de dibujo en la ventana.
            Bitmap imagen = new Bitmap(ancho, altura);

            //En esta imagen, creo un gráfico para dibujar.
            using (Graphics grafico = Graphics.FromImage(imagen))
            {
                #region Estilo y Color
                //Pongo el fondo del gráfico en blanco.
                grafico.Clear(Color.White);
                //Le indico al sistema que quiero que el gráfico use anti aliasing para mejorar la calidad visual.
                grafico.SmoothingMode = SmoothingMode.AntiAlias;
                //Creo una nueva lapicera de color negro y ancho mínimo posible 0.
                using (Pen lapicera = new Pen(Color.Black, 0))
                //Creo una nueva fuente Arial de punto flotante 0.1
                using (Font font = new Font("Arial", 0.1F))
                //Creo un nuevo tipo de pincelada de color negro sólido
                using (SolidBrush brush = new SolidBrush(Color.Black))
                #endregion
                {
                    #region Ajuste de Posición
                    //yMax indica el máximo valor de eje Y que voy a tener que considerar.
                    //La determino como el máximo valor de símbolo indicada en la tabla de verdad + 0.3 de margen.
                    double yMax = simbolosG.Max(y => y.Valor) + 0.3;
                    //yMin indica el mínimo valor de eje Y que voy a tener que considerar.
                    //La determino como la inversa al máximo valor (+A y -A)
                    double yMin = -yMax;

                    //xMax indica el máximo valor de eje X que voy a tener que considerar.
                    //La determino como la duración de transmisión de la cadena más 0.3 de margen.
                    double xMax = codigoG.Duracion + 0.3;
                    //xMin indica el mínimo valor de eje X que voy a tener que considerar.
                    //La determino como 0 menos un margen de 0.3.
                    double xMin = -0.3;

                    //Creo un rectángulo para indicar los límites del dibujo.
                    //Para esto, le doy:
                    //El xMin, punto inferior izquierdo.
                    //El yMax, punto superior izquierdo.
                    //Ancho = xMax - xMin.
                    //Altura = (-1) (yMax - yMin) = (yMin - yMax)
                    //Debido a como maneja C#, los valores de y están invertidos (arriba es negativo y abajo es positivo)
                    //Por eso, a cualquier operación sobre Y, agrego (-1)
                    RectangleF coordenadas = new RectangleF(
                        (float)xMin, (float)yMax,
                        (float)(xMax - xMin),
                        (float)(yMin - yMax));

                    //Indico las coordenadas virtuales del espacio de imagen. En Pixeles.
                    //Esto es para poder comparar ambos y crear un sistema de coordenadas.
                    PointF[] coordenadasVirtuales =
                    {
                    new PointF(0, 0),
                    new PointF(ancho, 0),
                    new PointF(0, altura)
                    };
                    #endregion

                    #region Creacion de Matriz
                    //Crea una nueva matriz que transforma geométricamente las coordenadas.
                    //Mapea las coordenadas en coordenadas virtuales.
                    Matrix transformMatrix = new Matrix(coordenadas, coordenadasVirtuales);

                    //Crea una nueva matriz identidad para la transformación del eje Y.
                    Matrix yTransform = new Matrix();

                    //Escala yTransform por un factor de 1 en el eje X y -1 en el eje Y.
                    //Esto efectivamente invierte el eje Y de yTransform,
                    //reflejando el sistema de coordenadas verticalmente.
                    yTransform.Scale(1, -1);

                    //Traduce la matriz yTransform moviendo el sistema de cooredanas
                    //hacia abajo una cantidad -altura en el eje Y.
                    yTransform.Translate(0, -altura);

                    //Multiplica la matriz transformMatrix por la matrzi yTransform.
                    //Este paso combina la transformación de coordenadas y la inversión vertical.
                    transformMatrix.Multiply(yTransform, MatrixOrder.Append);

                    //Establece en el gráfico que cualquier operación de dibujo debe pasar por la transformación.
                    grafico.Transform = transformMatrix;
                    #endregion

                    #region Dibujo de Coordenadas Cartesianas
                    //Dibujar el Eje X y Eje Y
                    //Para esto necesito la lapicera, el inicio (xMin e yMin) y el final (xMax e yMax) de línea.
                    grafico.DrawLine(lapicera, (float)xMin, 0, (float)xMax, 0);
                    grafico.DrawLine(lapicera, 0, (float)yMin, 0, (float)yMax);

                    // Dibujar valores de unidad en el eje X
                    //Para cada punto x entero entre el valor mín y máx.
                    for (double x = Math.Ceiling(xMin); x <= xMax; x++)
                    {
                        //Crear un punto en esa localización.
                        PointF point = new PointF((float)x, 0);
                        //Graficar una línea entre los puntos (x , -0.1f) y (x , 0.1f)
                        grafico.DrawLine(lapicera, point.X, -0.1f, point.X, 0.1f);
                        //Crear un texto del tamaño font, que represente a x (la unidad)
                        SizeF textSize = grafico.MeasureString(x.ToString(), font);
                        //Escrir el texto
                        grafico.DrawString(x.ToString(), font, brush, new PointF(point.X - textSize.Width / 2, 0.2f + textSize.Height / 2));
                    }
                    // Dibujar valores de unidad en el eje Y
                    for (double y = Math.Ceiling(yMin); y <= yMax; y++)
                    {
                        PointF point = new PointF(0, (float)y);
                        SizeF textSize = grafico.MeasureString(y.ToString(), font);
                        grafico.DrawLine(lapicera, 0.1f, point.Y, -0.1f, point.Y);
                        //En este caso, por consideración al eje de valores invertidos, se toma en cuenta -y.
                        if (y != 0) grafico.DrawString((-y).ToString(), font, brush, new PointF(- 0.2f - textSize.Width / 2, point.Y - textSize.Height / 2));
                    }
                    #endregion

                    if (codigoG.Cadena.Length > 0)
                    {
                        switch (modulacion)
                        {
                            case "ASK":
                                GraficadorASK.GraficarNASK(grafico, codigoG, senalG, simbolosG, tipo);
                                break;
                                //AQUÍ PUEDO AGREGAR NUEVOS CASOS DE MODULACIÓN
                        }
                    }
                }
            }
            return imagen;
        }
    }
}
