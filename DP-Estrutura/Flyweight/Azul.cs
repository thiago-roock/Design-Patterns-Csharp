using System;

namespace Flyweight
{
    public class Azul : Tartaruga
    {
        public Azul()
        {
            this.condicao = "tartaruga dentro do caso, ";
            this.acao = "rodando no chão - ";
        }
        public override void Mostra(string qualCor)
        {
            this.cor = qualCor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
