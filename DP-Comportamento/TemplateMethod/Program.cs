using System;
namespace TemplateMethod
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Design Pattern:"));
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Template Method"));
            Console.WriteLine("");
            Console.WriteLine("### Escolha o modo de corrida ###");
            Console.WriteLine("1 - Fácil | 2 - Normal | 3 - Jeová Deus");
            string op = string.Empty;
            Console.Write(@$"Opção: {op}");
            op = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Suas condições de jogo são: "); 
            Console.WriteLine("");
            Jogo jogo  = null;      
            jogo = EscolhaModo(op);
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer tecla para sair...");       
            Console.ReadKey(true);

             Jogo EscolhaModo(string modo) =>
                modo switch
                {
                    "1" => new ModoFacil(),
                    "2" => new ModoNormal(),
                    "3" => new ModoDificil(),
                    _   => throw new ArgumentException("Não implementado")
                };
        }

        
    }
}