using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class EnergiaBaseTerran : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base mecânica");
        }
    }
}
