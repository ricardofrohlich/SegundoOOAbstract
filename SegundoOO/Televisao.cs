﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoOO
{
    class Televisao : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("WebOS iniciando");
            //_ligado = true;
            Ligado = true;
        }
    }
}
