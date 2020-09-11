using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort an int
            int[] numeros = { 5, 1, 8, 9 };
            Array.Sort(numeros);
            Console.WriteLine("Numeros Sort do em ordem crescente");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("O maior valor é: " + numeros.Max());  // retorna o maior valor
            Console.WriteLine("O menor valor é: " + numeros.Min());  // retorna o menor valor
            Console.WriteLine("A soma dos valores é: " + numeros.Sum());  // retorna a soma dos elementos
            Console.ReadLine();
        }
    }
}
