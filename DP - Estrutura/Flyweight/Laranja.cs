using System;

namespace Flyweight
{
    public class Laranja : Tartaruga
    {
        public Laranja()
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
