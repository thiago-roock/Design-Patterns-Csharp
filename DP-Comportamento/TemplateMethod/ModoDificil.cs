using System;
namespace TemplateMethod
{
    public class ModoDificil: Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("O carro deve abastecer duas vezes");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversários devem correr mais");
        }
    }
}