using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayNumeros = { 10, 20, 30, 40 };
                      
            //Tamanho do array
            Console.WriteLine("Vc tem um array de " + ArrayNumeros.Length + " posicoes");

            //Lista os dados do array
            Console.WriteLine("Array com For");
            for(int i=0; i< ArrayNumeros.Length; i++)
            {
                Console.WriteLine(ArrayNumeros[i]);
            }
            Console.WriteLine("Array com Foreach");
            foreach(var i in ArrayNumeros)
            {
                Console.WriteLine(i);
            }

           
            Console.ReadLine();
        }
    }
}
