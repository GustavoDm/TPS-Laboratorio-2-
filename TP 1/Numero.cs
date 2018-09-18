using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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

        public Numero(string numero)
        {
            this.SetNumero = numero;
        }

        public string SetNumero
        {
            set
            {
                if (ValidarNumero(value) != 0)
                    this.numero = ValidarNumero(value);
            }
        }

        private static double ValidarNumero(string strNum)
        {
            double retorno = 0;
            bool Valido = false;

            Valido = double.TryParse(strNum, out retorno);
            if (Valido)
            {
                return retorno;
            }
            else
                return 0;
        }

        public static string BinarioDecimal(string binario)
        {
            string strNum = "";
            double decimalNum = 0;
            int size;
            bool valido;
            int i;

            valido = double.TryParse(binario, out decimalNum);

            if (valido)
            {
                size = binario.Length;

                for (i = 0; i < size; i++)
                {
                    if (binario.ElementAt(i) == '1')
                    {
                        decimalNum += Math.Pow(2, size - i - 1);
                    }
                    else if (binario.ElementAt(i) != 0)
                    {
                        return "Valor invalido";
                    }
                }
                strNum += decimalNum;
            }
            else
            {
                return "Valor invalido";
            }
            return strNum;
        }
        public static string DecimalBinario(double numero)
        {
            int contador = 0;
            double acumulador = 0;
            double potencia;
            string binario = "";
            int i;

            do
            {
                potencia = Math.Pow(2, contador);
                contador++;
            } while (potencia <= numero);

            for (i = contador; i >= 0; i--)
            {
                potencia = Math.Pow(2, i);
                if (numero >= acumulador + potencia)
                {
                    acumulador += potencia;
                    binario += "1";
                }
                else
                {
                    binario += "0";
                }

            }
            return binario;
        }

        public static string DecimalBinario(string numero)
        {
            bool valido;
            string retorno = "Valor invalido";
            double aux;
            valido = double.TryParse(numero, out aux);
            if (valido)
            {
                retorno = DecimalBinario(aux);

            }
            return retorno;
        }

        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero != 0)
                return num1.numero / num2.numero;
            else
                return double.MaxValue;

        }
    }
}
