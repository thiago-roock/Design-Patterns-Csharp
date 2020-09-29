using System;
using System.Collections.Generic;
namespace Visitor
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Template de projeto:"));
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("VISITOR"));

            List<IJogo> jogo = new List<IJogo>();
            jogo.Add(new FaseJogo(){NomeFase = "Floresta"});
            jogo.Add(new FaseJogo(){NomeFase = "Caverna"});
            jogo.Add(new Chefao(){NomeChefao = "Boss 1", PontosVida = 30}); 
            jogo.Add(new Chefao(){NomeChefao = "Boss 2", PontosVida = 50}); 
            NivelVisitor niveis = new NivelVisitor();
            foreach (var etapa in jogo)
            {
                etapa.Visitante(niveis);
            }

            Console.Write("\nDigite qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}