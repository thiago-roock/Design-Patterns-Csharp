using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite mapa = new Composite("MAPA DAS CAVERNAS");

            Composite caverna1 = new Composite("Caverna 1");
            caverna1.Adicionar(new FaseJogo("sub fase 1"));
            caverna1.Adicionar(new FaseJogo("sub fase 2"));
            caverna1.Adicionar(new FaseJogo("sub fase 3"));

            Composite caverna2 = new Composite("Caverna 2");
            caverna2.Adicionar(new FaseJogo("sub fase 4"));
            caverna2.Adicionar(new FaseJogo("sub fase 5"));

            Composite porta_secreta = new Composite("Porta secreta");
            porta_secreta.Adicionar(new FaseJogo("sub fase secreta x"));

            mapa.Adicionar(caverna1);
            mapa.Adicionar(caverna2);
            caverna2.Adicionar(porta_secreta);

            mapa.Mostrar(1);

            Console.ReadKey();


            Console.WriteLine("Hello World!");
        }
    }
}
