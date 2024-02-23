using System;
using System.Collections.Generic;

namespace TFI_Comunicaciones.Entidades
{
    #region Explicación
    //CodBinario (Codigo Binario)
    //Esta clase representa a la información a ser transmitida
    //Contiene:
    //La cadena de símbolos binarios.
    //La cantidad de símbolos dentro de la cadena. Se le asigna 0
    //si no coinciden longitud de la cadena y cifras por símbolo.
    //La duración de la cadena cuando se transmite. Se le asigna 0
    //en el mismo caso que el anterior.
    //Un método para calcular la cantidad de símbolos dado el dato de cifras por símbolo.
    //Un método para calcular la duración.
    //Un método para partir la cadena en sus string símbolos.
    #endregion

    public class CodBinario
    {
        private string cadena;
        private int simbolos;
        private double duracion;

        #region Propiedades
        public string Cadena
        {
            get { return cadena; }
            set { this.cadena = value; }
        }
        public int Simbolos
        {
            get { return simbolos; }
            set { this.simbolos = value; }
        }
        public double Duracion
        {
            get { return duracion; }
            set { this.duracion = value; }
        }
        #endregion

        public List<string> calcularSimbolos(int bitsSimb)
        {
            List<string> simbolos = new List<string>();
            for (int i = 0; i < cadena.Length; i += bitsSimb)
            {
                int longitud = Math.Min(bitsSimb, cadena.Length - i);
                string simb = cadena.Substring(i, longitud);
                simbolos.Add(simb);
            }
            return simbolos;
        }
        public int calcularCantSimbolos(int bitsSimb) {
            if(cadena.Length % bitsSimb == 0) { this.Simbolos = cadena.Length / bitsSimb; }
            else { this.Simbolos = 0; }
            return simbolos;
        }
        public double calcularDuracion(int bitsSimb, double periodo)
        {
            int n = calcularCantSimbolos(bitsSimb);
            this.Duracion = n * periodo;
            return duracion;
        }

        public CodBinario()
        {
            this.cadena = "";
        }
        public CodBinario(string cod)
        {
            this.cadena = cod;
        }
    }
}
