using System;
using System.Text;
namespace Observer
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Template de projeto:"));
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("OBSERVER"));

            Cody cody = new Cody();
            Inimigo Inimigo1 = new Inimigo(cody);
            Inimigo Inimigo2 = new Inimigo(cody);
            Inimigo Inimigo3 = new Inimigo(cody);

            while (true)
            {
                Console.WriteLine("Acertar o Cody com um golpe (S ou N)?");
                if(Console.ReadLine()== "s")
                    cody.Golpe_Acertado(true);
                else 
                    Console.WriteLine("Você não acertou o Cody!");
            }

        }
    }
}