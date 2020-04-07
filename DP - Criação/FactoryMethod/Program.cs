using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();
            Console.Write("Street Fighter");
            Console.WriteLine();

            Console.WriteLine("Ryu | Ken | Chun li");
            Console.WriteLine();

            Console.Write("Escolha seu personagem: ");
            string escolha = Console.ReadLine();

            IPersonagem Personagem = fm.Escolher_Personagem(escolha);

            Console.WriteLine();
            Console.Write("Você vai jogar com ");
            Personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
