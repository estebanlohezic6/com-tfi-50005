using System;
using System.Collections.Generic;
using System.Drawing;
using TFI_Comunicaciones.Entidades;

namespace TFI_Comunicaciones.Graficadores
{
    #region Explicación
    //GraficadorASK (Graficadora de ASK)
    //Esta cláse estática recibe el grafico con las coordenadas cartesianas
    //y todas las entidades necesarias para realizar la gráfica de uno de los
    //aspectos de NASK.
    //Cualquier implementación de otro tipo de modulación debería ser realizado
    //con esta clase como plantilla.
    #endregion
    public static class GraficadorASK
    {
        public static Graphics GraficarNASK(Graphics grafico,
                                          CodBinario codigoG,
                                          Senal senalG,
                                          List<ValorSimb> simbolosG,
                                          tipoGrafica quieroGrafica)
        {
            //Establezco la lapicera y selecciono el gráfico donde voy a dibujar.
            using (Pen lapicera = new Pen(Color.Red, 0))
            using (grafico)
            {
                //Genero la lista de símbolos incluidos en la cadena binaria enviada.
                List<string> lista = codigoG.calcularSimbolos(senalG.CifrasSimb);

                //Genero la lista de puntos incluidos en la gráfica. Los cuales el gráfico va a dibujar.
                List<PointF> puntosASK = new List<PointF>();

                //Creo los límites en eje X del primer símbolo enviado. De 0 a Periódo del Símbolo
                double xActual = 0;
                double finPeriodo = senalG.PeriodoSimb;

                //Uso un switch para indicar el comportamiento diferente en los distintos tipos de gráfica.
                switch (quieroGrafica)
                {
                    //QUIERO VER LA GRÁFICA DE LA PORTADORA
                    #region Portadora
                    case tipoGrafica.Portadora:
                        foreach (string s in lista)
                        {
                            for (float x = (float)xActual; x <= finPeriodo; x += (float)0.0001)
                            {
                                //Para graficar la Portadora, quito la consideración de la amplitud de la fórmula anterior.
                                //Formula : V(t) = Sen( 2Pi * f * t) 
                                //De nuevo, incluir (-!) evita que el gráfico se vea invertido sobre el eje Y.
                                float y = (float)((-1) *
                                Math.Sin(2 * Math.PI * senalG.Frecuencia * x));
                                puntosASK.Add(new PointF(x, y));
                            }
                            xActual = finPeriodo;
                            finPeriodo = xActual + senalG.PeriodoSimb;
                        }
                        grafico.DrawLines(lapicera, puntosASK.ToArray());
                        break;
                    #endregion

                    //QUIERO VER LA GRÁFICA DE LA MODULADORA
                    #region Moduladora
                    case tipoGrafica.Moduladora:
                        foreach (string s in lista)
                        {
                            ValorSimb enviado = simbolosG.Find(simb => simb.Simbolo.Equals(s));

                            for (float x = (float)xActual; x <= finPeriodo; x += (float)0.0001)
                            {
                                //Para graficar la Moduladora, quito la consideración del seno de la fórmula y
                                ////tomo únicamente las amplitudes de símbolos.
                                float y = (float)((-1) * enviado.Valor);
                                puntosASK.Add(new PointF(x, y));
                            }
                            xActual = finPeriodo;
                            finPeriodo = xActual + senalG.PeriodoSimb;
                        }
                        grafico.DrawLines(lapicera, puntosASK.ToArray());
                        break;
                    #endregion

                    //QUIERO VER LA GRÁFICA DE LA MODULADA
                    #region Modulada
                    case tipoGrafica.Modulada:
                        foreach (string s in lista)
                        {
                            //Busco el simbolo enviado con su amplitud establecida.
                            ValorSimb enviado = simbolosG.Find(simb => simb.Simbolo.Equals(s));

                            //Dibujo los puntos de la gráfica que corresponden al símbolo.
                            for (float x = (float)xActual; x <= finPeriodo; x += (float)0.0001)
                            {
                                //Fórmula : V(t) = A * Sen( 2Pi * f * t) 
                                //Se agrega un (-1) al inicio debido a que en este formato (image), el eje vertical es invertido.
                                float y = (float)((-1) * enviado.Valor *
                                    Math.Sin(2 * Math.PI * senalG.Frecuencia * x));

                                //Añado el punto a la lista por dibujar
                                puntosASK.Add(new PointF(x, y));
                            }

                            //Una vez terminado de graficar el símbolo, muevo el graficador al siguiente símbolo.
                            //Para esto, establezco el X actual en fin del simbolo y el nuevo fin de periodo se calcula.
                            xActual = finPeriodo;
                            finPeriodo = xActual + senalG.PeriodoSimb;
                        }
                        //Grafico la curva que une los puntos ASK.
                        grafico.DrawLines(lapicera, puntosASK.ToArray());
                        break;
                        #endregion
                }
            }
            return grafico;
        }
    }
}
