using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor vermelho");
        }
    }
}
