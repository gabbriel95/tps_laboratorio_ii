using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el operador sea + - / *, caso contrario devuelve 'e' de error
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> retorno el operador o una 'e' si hubo un error</returns>
        private static char ValidarOperador(char operador)
        {

            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }

            return '+';
        }

        /// <summary>
        /// Realiza la operacion de los numeros pasados como parametros segun el operador 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado: resultado de la operacion entre num1 y num2</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }

            return resultado;
        }

    }
}
