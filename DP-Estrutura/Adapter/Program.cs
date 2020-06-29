using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem = new Personagem();
            Aviao aviao_de_batalha = new Aviao();

            IAcao adaptador = new Adapter(aviao_de_batalha);

            Console.WriteLine("---CAMINHANDO---");
            personagem.Andar("Thiago");
            personagem.Atirar();

            Console.WriteLine();

            Console.WriteLine("--- PEGOU UM AVIÃO NO JOGO ---");
            adaptador.Andar("Thiago");
            adaptador.Atirar();

            Console.ReadKey();


        }
    }
}
