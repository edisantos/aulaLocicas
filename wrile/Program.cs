using System;

namespace wrile
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um numero de 0 a 10");
            numero = int.Parse(Console.ReadLine());

            while (numero!= 10)
            {
                Console.WriteLine("Ops Errou! Tente outro numero");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acertou!!!");
            Console.ReadKey();
        }
    }
}
