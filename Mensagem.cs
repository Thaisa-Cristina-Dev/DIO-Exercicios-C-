using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public class Mensagem
    {
        public Mensagem(string texto)
        {
            Texto = texto;
            Reacoes = new List<string>();
        }

        public string Texto { get; set; }
        public List<string> Reacoes { get; set; }
    }
}
