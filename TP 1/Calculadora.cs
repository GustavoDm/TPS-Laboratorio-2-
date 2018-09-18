using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";

            switch (operador)
            {
                case "-":
                    retorno = "-";
                    break;
                case "*":
                    retorno = "*";
                    break;
                case "/":
                    retorno = "/";
                    break;

            }
            return retorno;
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado;

            operador = ValidarOperador(operador);

            switch (operador)
            {

                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;

                default:
                    resultado = num1 + num2;
                    break;

            }

            return resultado;

        }
    }
}
