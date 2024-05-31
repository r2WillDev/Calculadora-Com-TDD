using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string Data;

        public Calculadora(string Data) 
        {
            ListaHistorico = new List<string>();
            this.Data = Data;
        }
        public int Somar(int val1, int val2)
        {
            int soma = val1 + val2;
            
            ListaHistorico.Insert(0, "resultado: " + soma + " - data: " + Data);
            return soma;
        }

        public int Subtrair(int val1, int val2)
        {
            int subtrair = val1 - val2;
            ListaHistorico.Insert(0, "resultado: " + subtrair + " - data: " + Data);

            return subtrair;
        }

        public int Multiplicar(int val1, int val2)
        {
            int multiplicar = val1 * val2;
            ListaHistorico.Insert(0, "resultado: " + multiplicar + " - data: " + Data);
            return multiplicar;
        }

        public int Dividir(int val1, int val2)
        {
            int dividir = val1 / val2;
            ListaHistorico.Insert(0, "resultado: " + dividir + " - data: " + Data);
            return dividir;
        }

        public List<string> Historico()
        { 
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}
