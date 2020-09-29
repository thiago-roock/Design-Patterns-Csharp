using System;
namespace Command
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Template de projeto:"));
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render("COMMAND"));

            Controle controle = new Controle();
            controle.EnviarComandoSimples(new SimplesComando("Dizer oi"));

            Receiver receiver = new Receiver();
            controle.EnviarComandoComplexo(new ComplexoComando(receiver,"abastecer carro","calibrar pneus do carro"));

            controle.Fazer();
            
            Console.Write("\nDigite qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}