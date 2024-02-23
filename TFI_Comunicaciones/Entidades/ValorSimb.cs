using System;

namespace TFI_Comunicaciones.Entidades
{
    #region Explicación
    //AmpSimb (Amplitud / Simbolo)
    //Esta clase representa la relación entre un símbolo
    //dado y el valor utilizado para representarlo en la
    //señal transmitida.
    //Contiene el símbolo string y su valor.
    #endregion

    public class ValorSimb
    {
        private string simbolo;
        private double valor;

        #region Propiedades
        public string Simbolo
        {
            get { return simbolo; }
            set { this.simbolo = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { this.valor = value; }
        }
        #endregion

        public ValorSimb(string simbolo, double amplitud)
        {
            this.simbolo = simbolo;
            this.valor = amplitud;
        }
    }
}
