using System;

namespace TFI_Comunicaciones.Entidades
{
    #region Explicación
    //Senal (Señal)
    //Esta clase contiene los atributos de la señal portadora.
    //Contiene como atributos:
    //La frecuencia de la señal.
    //El radio de baudios (simbolos transmitidos/segundo)
    //El periodo bit (cuanto le toma a la frecuencia realizar un ciclo +A a -A o transmitir 1 bit)
    //El periodo simb (cuanto le toma a la señal transmitir un símbolo de n bits)
    //El número de cifras binarias en un símbolo.
    #endregion

    public class Senal
    {
        private double frecuencia;
        private double baudios;
        private double periodoBit;
        private double periodoSimb;
        private int cifrasSimb;

        #region Propiedades
        public double Frecuencia
        {
            get { return this.frecuencia; }
            set
            {
                this.frecuencia = value;
                this.periodoBit = 1 / this.frecuencia;
                this.periodoSimb = this.periodoBit * cifrasSimb;
                this.baudios = 1/periodoSimb;
            }
        }
        public double PeriodoBit
        {
            get { return this.periodoBit; }
            set
            {
                this.periodoBit = value;
                this.frecuencia = 1 / this.periodoBit;
                this.periodoSimb = this.periodoBit * cifrasSimb;
                this.baudios = 1/periodoSimb;
            }
        }
        public double PeriodoSimb
        {
            get { return periodoSimb; }
            set { 
                this.periodoSimb = value;
                this.periodoBit = this.periodoSimb / cifrasSimb;
                this.frecuencia = 1 / this.periodoBit;
                this.baudios = 1 / periodoSimb;
            }
        }
        public double Baudios
        {
            get { return this.baudios; }
            set
            {
                this.baudios = value;
                this.periodoSimb = 1 / baudios;
                this.periodoBit = periodoSimb / cifrasSimb;
                this.frecuencia = 1/periodoBit;
            }
        }
        public int CifrasSimb
        {
            get { return cifrasSimb; }
            set { 
                this.cifrasSimb = value;
                this.periodoBit = 1 / frecuencia;
                this.periodoSimb = periodoBit * cifrasSimb;
                this.baudios = 1 / periodoSimb;
            }
        }
        #endregion

        public Senal()
        {
            this.Frecuencia = 1;
            this.CifrasSimb = 1;
        }
    }
}
