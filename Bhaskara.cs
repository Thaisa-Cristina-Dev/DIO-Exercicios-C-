using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    public class Bhaskara
    {
        public static void Calculo()
        {
            int valorA = ValidarValor("Digite o valor de a:");
            int valorB = ValidarValor("Digite o valor de b:");
            int valorC = ValidarValor("Digite o valor de c:");

            double delta = (Math.Pow(valorB, 2) - (4 * valorA * valorC));
            double raiz = Math.Sqrt(delta);

            var x1 = (-valorB + raiz) / (2 * valorA);
            var x2 = (-valorB - raiz) / (2 * valorA);

            if (valorA != 0 && delta > 0)
            {
                Console.WriteLine("Valor de X1': {0}", x1.ToString("F5"));
                Console.WriteLine("Valor de X2'': {0}", x2.ToString("F5"));
            }
            else
            {
                Console.WriteLine("Não foi possivel realizar o calculo: Delta menor que zero");
            }

            Console.ReadLine();
        }

        private static int ValidarValor(string pergunta)
        {
            var valorConvertido = 0;

            Console.WriteLine(pergunta);
            while (!int.TryParse(Console.ReadLine(), out valorConvertido))
            {
                Console.WriteLine(pergunta);
            }

            return valorConvertido;
        }
    }
}
