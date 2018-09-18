using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero num1 = new Numero();
            num1.SetNumero = "5";
            Numero num2 = new Numero(20);
            double aux = num1 + num2;
            Console.WriteLine(aux);
            Console.ReadKey();
        }
    }
}
