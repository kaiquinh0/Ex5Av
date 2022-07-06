using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5Av
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Fazer um programa para encontrar todos os números pares entre 1 e 100.
            int contador = 0;
            while (contador < 100)
            {
                contador = contador + 2;
                Console.WriteLine(contador);
            }
            Console.ReadKey();
        }
    }
}
