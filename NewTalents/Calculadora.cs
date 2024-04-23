using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;

        public Calculadora(string data)
        {
            historico = new List<string>();
            this.data = data;
        }
        public int Somar(int num1, int num2)
        {
            int res =num1 + num2;
            historico.Insert(0, "Res:" + res + "- data: " + data);
            return res;
        }

        public int Subtrair(int num1, int num2)
        {
            int res =num1 - num2;
            historico.Insert(0, "Res:" + res + "- data: " + data);
            return res;
        }

        public int Multiplicar(int num1, int num2)
        {
            int res =num1 * num2;
            historico.Insert(0, "Res:" + res + "- data: " + data);
            return res;
        }

        public int Dividir(int num1, int num2)
        {
            int res =num1 / num2;
            historico.Insert(0, "Res:" + res + "- data: " + data);
            return res;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}