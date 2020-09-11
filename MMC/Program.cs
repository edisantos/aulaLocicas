using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            float imc, massa, altura;
            const string sTitulo = "\nCalculo do IMC";
            const string sMassa = "Informe o peseo (Kg): ";
            const string sAltura = "Informe a altura (m): ";
            string sMsg = "Resultado: ";

            Console.WriteLine(sTitulo);
            Console.WriteLine();

            Console.Write(sMassa);
            massa = float.Parse(Console.ReadLine());

            Console.Write(sAltura);
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine();

            imc = massa / (altura * altura);

            if (imc < 16)
                sMsg += "Magreza severa";
            else if (imc < 17)
                sMsg += "Magreza modera";
            else if (imc < 18.5)
                sMsg += "Magreza Leve";
            else if (imc < 25)
                sMsg += "Peso normal";
            else if (imc < 30)
                sMsg += "Sobrepeso";
            else if (imc < 35)
                sMsg += "Obesidade classe 1";
            else if (imc < 40)
                sMsg += "Obeseidade classe 2";
            else
                sMsg += "Obesidade classe 3";

            Console.WriteLine(sMsg + "- IMC = " + imc);
            Console.ReadLine();
        }
    }
}
