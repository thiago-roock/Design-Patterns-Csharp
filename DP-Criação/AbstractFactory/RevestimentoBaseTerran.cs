using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class RevestimentoBaseTerran : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor verde");
        }
    }
}
