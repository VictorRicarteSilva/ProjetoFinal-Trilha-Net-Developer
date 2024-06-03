using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_Trilha_Net_Developer
{
    public static class Calculadora
    {
        private static List<string> Historico = new List<string>(); 

        public static int somar(int valor, int valor2)
        {
            Historico.Insert(0, $"{valor} + {valor2} = {valor + valor2}");
            return valor + valor2;
        }
        public static int subtrair(int valor, int valor2)
        {
            Historico.Insert(0, $"{valor} - {valor2} = {valor - valor2}");
            return valor - valor2;
        }
        public static int multiplicar(int valor, int valor2)
        {
            Historico.Insert(0, $"{valor} * {valor2} = {valor * valor2}");
            return valor * valor2;
        }
        public static int dividir(int valor, int valor2)
        {
            Historico.Insert(0, $"{valor} / {valor2} = {valor / valor2}");
            return valor / valor2;
        }
        public static List<string> historico()
        {
            Historico.RemoveRange(3, Historico.Count - 3);
            return Historico;
        }
    }
}
