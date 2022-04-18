using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            Numero = numero.ToString();
        }

        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        /// <summary>
        /// Asigna un valor al atributo numero
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }




        /// <summary>
        /// Valida que el valor recibido sea un numero y lo retorna como un double
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>retorno: retorna el valor en double</returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno;

            if (!String.IsNullOrEmpty(strNumero) && double.TryParse(strNumero, out retorno))
            {
                return retorno;

            }

            return 0;
        }

        /// <summary>
        /// Verifica que la cadena string sea binaria
        /// </summary>
        /// <param name="text"></param>
        /// <returns>True: Si es binaria False: si no lo es</returns>
        private static bool EsBinario(string text)
        {
            bool resultado = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '0' || text[i] == '1')
                {
                    continue;
                }
                else 
                {
                    resultado = false;
                    break;
                }
            }

            return resultado;
        }
        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Si era binario y pudo pasarlo a decimal devuelve un string con el numero, sino Valor invalido</returns>
        public static string BinarioDecimal(string binario)
        {
            string numeroString = binario.ToString();
            int numeroIndividual;
            double multiplicador = 0;
            int acumulador = 0;

            if (EsBinario(numeroString)) 
            {
                for (int i = 0; i < numeroString.Length; i++)
                {
                    int.TryParse(numeroString.Substring(i, 1), out numeroIndividual);
                    multiplicador = Math.Pow(2, (numeroString.Length - 1) - i);
                    acumulador += Convert.ToInt32(multiplicador * numeroIndividual);
                }

                return acumulador.ToString();
            }

            return "Valor invalido";
        }
        /// <summary>
        /// Pasa un numero decimal a binario
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numeroEntero)
        {
            string numeroBinario = "";
            int divisor = 2;
            int resto;

            for (int i = 0; numeroEntero >= divisor; i++)
            {
                resto = (int)numeroEntero % 2;
                numeroEntero = Math.Floor(numeroEntero / divisor);

                numeroBinario += resto;

                if (numeroEntero < divisor)
                {
                    numeroBinario += numeroEntero;
                    numeroBinario = Reverse(numeroBinario);
                    return numeroBinario;
                }
            }


            return "Valor invalido";
        }
        /// <summary>
        /// Pasa un numero decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            double num;
            string resultado;
            if (double.TryParse(numero, out num))
            {
                resultado = DecimalBinario(num);
                return resultado;
            }

            return "Valor invalido";
        }

        /// <summary>
        /// Revierte un string de char
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator /(Operando num1, Operando num2)
        {
            if (num2.numero == 0)
                return double.MinValue;

            else
                return num1.numero / num2.numero;
        }

    }
}
