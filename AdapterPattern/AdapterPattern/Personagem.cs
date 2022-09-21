﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Personagem : IAcao
    {
        public void Andar(string personagem)
        {
            Console.WriteLine(personagem + "	ANDOU PARA FRENTE!");
        }

        public void Atirar()
        {
            Console.WriteLine("Atirou no jogo!");
        }
    }
}
