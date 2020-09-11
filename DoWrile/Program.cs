using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoWrile
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, total;
            string op;
            string sair;
            do
            {


                Console.WriteLine("Qual o valor? ");
                n1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Que tipo de operacao deseja fazer? ");
                Console.WriteLine("[+] Somar\n[-] Subtrair\n[/] Divisão\n[*] Multiplicacao");
                op = Console.ReadLine();

                Console.WriteLine("Qual o proximo valor? ");
                n2 = float.Parse(Console.ReadLine());

               
                switch (op)
                {
                    case "+":
                        total = n1 + n2;
                        Console.WriteLine("Tatal: " + total);
                        break;
                    case "-":
                        total = n1 - n2;
                        Console.WriteLine("Tatal: " + total);
                        break;
                    case "/":
                        total = n1 / n2;
                        Console.WriteLine("Tatal: " + total);
                        break;
                    case "*":
                        total = n1 * n2;
                        Console.WriteLine("Tatal: " + total);
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Deseja continuar? \n[S] Para sair\n[C] Continuar");
                sair = Console.ReadLine();
            } while (sair != "S");

            
            

            Console.ReadLine();
        }
    }
}
