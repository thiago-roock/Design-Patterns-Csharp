using System;
namespace Chain_of_Responsability
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Template de projeto:"));
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("CHAIN OF RESPONSABILITY"));

            Manipulador pA = new PersonagemA();
            Manipulador pB = new PersonagemB();
            Manipulador pC = new PersonagemC();

            pA.defineSucessor(pB);
            pB.defineSucessor(pC);

            int[] requisicoes = {5,8,15,20,18,3,27,20};

            foreach (var req in requisicoes)
            {
                pA.Convoca(req);
            }

            Console.Write("\nDigite qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}