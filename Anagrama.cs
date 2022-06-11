using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Anagrama
    {
        public static void Calculo()
        {
            Console.Write("Entre com a primeira palavra: ");
            string str1 = Console.ReadLine();

            Console.Write("Entre com a segunda palavra: ");
            string str2 = Console.ReadLine();

            if (ValidarAnagrama(str1, str2))
            {
                Console.WriteLine("As palavras são um anagrama.");
            }
            else
            {
                Console.WriteLine("As palavras não são um anagrama.");
            }

            Console.ReadLine();
        }

        public static bool ValidarAnagrama(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            var s1Array = s1.ToLower().ToCharArray();
            var s2Array = s2.ToLower().ToCharArray();

            Array.Sort(s1Array);
            Array.Sort(s2Array);

            s1 = new string(s1Array);
            s2 = new string(s2Array);

            return s1 == s2;
        }
    }
}
