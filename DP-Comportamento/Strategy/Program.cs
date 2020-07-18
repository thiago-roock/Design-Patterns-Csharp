using System;
namespace MyProject
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Template de projeto:"));
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("CONSOLE"));

            Console.Write("\nDigite qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}