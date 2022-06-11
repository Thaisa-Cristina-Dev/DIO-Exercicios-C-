using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public class MensagemVideo : Mensagem
    {
        public MensagemVideo(string texto, string linkVideo) : base(texto)
        {
            LinkVideo = linkVideo;
        }

        public string LinkVideo { get; set; }
    }
}
