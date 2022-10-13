using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoOO
{
    class PlayStation : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Estou ligando o PlayStation");
            //_ligado = true;
            this.Ligado = true;
        }
    }
}
