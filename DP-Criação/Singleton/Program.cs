using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador_1 = Singleton.GetInstancia;
            jogador_1.Mensagem("jogador 1: A bola está comigo no meio do campo");

            Singleton jogador_2 = Singleton.GetInstancia;
            jogador_2.Mensagem("jogador 2: Recebeu a bola");

            Singleton jogador_3 = Singleton.GetInstancia;
            jogador_3.Mensagem("jogador 3: Recebeu o lançamento na linha de fundo");

            Console.ReadKey();

        }
    }
}
