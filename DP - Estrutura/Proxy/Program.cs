using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Acessando a Fase do jogo sem o Proxy ####");
            FaseJogo fase = new FaseJogo();
            Console.WriteLine(fase.Jogar());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
