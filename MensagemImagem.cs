using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public class MensagemImagem : Mensagem
    {
        public MensagemImagem(string texto, string linkImagem) : base(texto)
        {
            LinkImagem = linkImagem;
        }

        public string LinkImagem { get; set; }
    }
}
