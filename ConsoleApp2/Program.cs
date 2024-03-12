using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura: ");
            double alt = double.Parse(Console.ReadLine());

            double imc = peso / (alt * alt);

            Console.WriteLine("Sei IMC é: " + imc);

            if (imc <= 17)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc <= 18.4)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Obesidade grau 1");
            }
            else if (imc <= 40)
            {
                Console.WriteLine("Obesidade grau 2");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade grau 3");
            }
            Console.ReadKey();
        }
    }
}
