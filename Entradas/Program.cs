using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entradas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int anoNasc;
            int atual = DateTime.Now.Year;
            int idade;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Entre com seu ano de nascimento : ");
            anoNasc = int.Parse(Console.ReadLine());
            idade = atual - anoNasc;
            //Tomada de descisoes
            if(idade < 18)
            {
                Console.Write("Ola " + nome + " Idade: " + idade + " Voce é de menor idade");
            }
            else
            {
                Console.Write("Ola " + nome + " Idade: " + idade + " Voce é de maior idade");
            }
           // Console.WriteLine("Ola: " + nome + " sua idade é: " + idade);

            Console.ReadKey();

        }
    }
}
