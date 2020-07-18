using System;
namespace TemplateMethod
{
    public class ModoNormal: Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("O carro precisa abastecer uma vez");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversários devem correr na mesma velocidade");
        }
    }
}