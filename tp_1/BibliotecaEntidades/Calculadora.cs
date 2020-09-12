using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public static class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double res = 0;
            string op = ValidarOperador(Convert.ToChar(operador));
            switch (op)
            {
                case "+":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    res = num1 / num2;
                    break;
            }
            return res;
        }

        private static string ValidarOperador(char operador)
        {
            char[] op = new char[] { '+', '-', '/', '*' };
            string mas = op[0].ToString();
            string caracter = operador.ToString();

            if (operador == op[1] || operador == op[2] || operador == op[3])
            {
                return caracter;
            }

            return mas;

        }

    }
}
