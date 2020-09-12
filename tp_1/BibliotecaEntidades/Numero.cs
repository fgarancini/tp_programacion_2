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
        /// <summary>
        ///  Constructor de Numero inicializa en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Utiliza la prop Set numero para settear por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            SetNumero = numero.ToString();
        }
        /// <summary>
        /// Utiliza la prop Set numero para settear por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        /// <summary>
        ///  Setter, validado el Value settea el dato
        /// </summary>
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
        /// <summary>
        /// Valida por medio de una estructura repetitiva que la cadena contenga numeros
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
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
        /// <summary>
        ///  Valida por estructura repetitiva que la cadena contenga 1 y 0
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
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
        /// <summary>
        ///  Por uso de una cadena repetitiva y Validada la cadena si cada numero corresponde al ASCII '1' = 49 suma las potencias de esos numeros de forma inversa
        /// </summary>
        /// <param name="bin"></param>
        /// <returns></returns>

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
        /// <summary>
        ///  Igualo la primero poscicion del array al numero por parametro y luego lo divido iterando hasta que la division devuelva 1
        ///  Luego de atras hacia adelante uso el mismo array para sacar el resto de los numeros alojados en resto[] pasandoselos al array de Binarios
        ///  Con el metodo de string los uno en una cadena y la devuelvo.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Reutilizo el codigo anterior haciendo un casteo de tipo de dato
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            string cadenaBinaria;
           
            double binario = double.Parse(numero);

            cadenaBinaria = DecimalBinario(binario);

            return cadenaBinaria;
        }

        #endregion

        #region Operaciones
        /// <summary>
        ///  Sobrecarga de operaciones
        ///  La sobrecarga del Divisor condiciona que si el n2 es = a 0 devuelva double.MinValue
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
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
