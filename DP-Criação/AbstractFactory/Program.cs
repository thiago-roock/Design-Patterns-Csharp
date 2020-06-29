using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabricaBases fabrica;
            Console.Write("Escolha um dos personagens: 1- Protoss | 2 - Zerg | 3 - Terranos: ");

            fabrica = Console.ReadLine() switch
            {
                "1" => new FabricaBaseProtoss(),
                "2" => new FabricaBaseZerg(),
                "3" => new FabricaBaseTerran(),
                _ => null
            };

            Console.ReadLine();
        }
    }
}
