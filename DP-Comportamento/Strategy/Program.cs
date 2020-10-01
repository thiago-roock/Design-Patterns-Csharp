using System;
namespace Strategy
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Template de projeto:"));
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("STRATEGY"));

            Ajuda papagaio = new Ajuda(new Papagaio());
            Console.WriteLine(papagaio.Ajudar());

            Ajuda sapo = new Ajuda(new Sapo());
            Console.WriteLine(sapo.Ajudar());


            Console.Write("\nDigite qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}