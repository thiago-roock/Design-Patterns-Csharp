using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Personagem : IAcao
    {
        public void Andar(string personagem)
        {
            Console.WriteLine(personagem + " ANDOU PARA FRENTE!");

        }

        public void Atirar()
        {
            Console.WriteLine("Atirou no jogo!");
        }
    }
}
