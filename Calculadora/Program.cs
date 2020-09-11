using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,total;
            string oper;
            Console.Write("Entre com numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tipo de operacao");
            oper = Console.ReadLine();
            Console.Write("Entre com outro numero : ");
            n2 = int.Parse(Console.ReadLine());
            
            switch (oper)
            {
                case "+":
                    total = n1 + n2;
                    Console.WriteLine("Total: " + total);
                    break;
                case "-":
                    total = n1 - n2;
                    Console.WriteLine("Total: " + total);
                    break;
                case "*":
                    total = n1 * n2;
                    Console.WriteLine("Total: " + total);
                    break;
                case "/":
                    total = n1 / n2;
                    Console.WriteLine("Total: " + total);
                    break;
            }
            //if(oper == "+")
            //{
            //    total = n1 + n2;
            //    Console.WriteLine("Total: " + total);
            //}
            //if (oper == "-")
            //{
            //    total = n1 - n2;
            //    Console.WriteLine("Total: " + total);
            //}
            //if (oper == "*")
            //{
            //    total = n1 * n2;
            //    Console.WriteLine("Total: " + total);
            //}
            //if (oper == "/")
            //{
            //    total = n1 / n2;
            //    Console.WriteLine("Total: " + total);
            //}
            //Tomada de descisoes


            Console.ReadKey();
        }
    }
}
