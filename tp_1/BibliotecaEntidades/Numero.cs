using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        #region propiedades
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Validadores
        private static double ValidarNumero(string strNumero)
        {
            char[] cadenaNumeros = strNumero.ToCharArray();
            bool ok = false;
            for (int i = 0; i < cadenaNumeros.Length; i++)
            {
                if (cadenaNumeros[i] >= '0' && cadenaNumeros[i] <= '9')
                {
                    ok = true;
                }
            }

            if (ok)
            {
                return double.Parse(strNumero);
            }
            else
            {
                return 0;
            }

        }

        private static bool EsBinario(string binario)
        {
            char[] cadenaBinaria = binario.ToCharArray();
            bool ok = false;
            for (int i = 0; i < binario.Length; i++)
            {
                if (cadenaBinaria[i] == '0' || cadenaBinaria[i] == '1')
                {
                    ok = true;
                }
                else
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion


        #region OperacionesDecimalesBinarias
        public static string BinarioDecimal(string bin)
        {
            bool esBinario = EsBinario(bin);
            int[] numeros = new int[bin.Length];
            int j = 0;
            int sum = 0;

            if (esBinario)
            {
                for (int i = bin.Length - 1; i >= 0; i--)
                {
                    numeros[i] = (int)bin[i];
                    j++;
                    if (numeros[i] == 49)
                    {
                        sum += (int)Math.Pow(2, j - 1);
                    }
                }
                return sum.ToString();
            }
            else
            {
                return "Valor invalido";
            }
        }

        public static string DecimalBinario(double numero)
        {
            string cadenaBinaria;
            int[] resto = new int[50];
            int i = 0;
            int h = 1;
            resto[0] = (int)numero;

            while (resto[i] > 1)
            {
                resto[h] = resto[i] / 2;
                i++;
                h++;
                if (resto[h] / 2 == 1)
                {
                    break;
                }
            }
            double[] binarios = new double[h];

            for (int j = 0; j < h; j++)
            {
                binarios[j] = resto[i - j] % 2;
            }

            cadenaBinaria = string.Join("", binarios);

            return cadenaBinaria;
        }
        public static string DecimalBinario(string numero)
        {
            string cadenaBinaria;
           
            double binario = double.Parse(numero);

            cadenaBinaria = DecimalBinario(binario);

            return cadenaBinaria;
        }

        #endregion

        #region Operaciones

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        #endregion
    }
}
