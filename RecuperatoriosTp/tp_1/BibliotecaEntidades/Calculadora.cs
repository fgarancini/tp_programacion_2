using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Con las sobrecargas de Numero la suma de los objetos es retornada segun el operador
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, char operador)
        {
            double res = 0;
            
            switch (operador)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
            }
            return res;
        }
        /// <summary>
        /// Valida que el operador sea correcto en caso contrario devuelve siempre mas (+)
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
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
