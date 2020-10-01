using System;
namespace Chain_of_Responsability
{
    public class PersonagemA: Manipulador
    {
        public override void Convoca(int quantidadePoder)
        {
            if(quantidadePoder >= 0 && quantidadePoder < 10)
                Console.WriteLine($"{this.GetType().Name} convocado para uma força de poder de {quantidadePoder}");
            else if(sucessor != null)
                sucessor.Convoca(quantidadePoder);
        }   
    }
}