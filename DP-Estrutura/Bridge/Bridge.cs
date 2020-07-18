using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Bridge
    {
        public IForma forma_solicitada { get; set; }
        public void ExibeQualFormaEstaDescendoNaTela()
        {
            Console.WriteLine(forma_solicitada.Descer());
        }
    }
}
