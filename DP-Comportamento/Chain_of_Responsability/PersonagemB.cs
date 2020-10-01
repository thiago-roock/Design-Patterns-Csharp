using System;
namespace Chain_of_Responsability
{
    public class PersonagemB: Manipulador
    {
        public override void Convoca(int quantidadePoder)
        {
            if(quantidadePoder >= 10 && quantidadePoder < 20)
                Console.WriteLine($"{this.GetType().Name} convocado para uma força de poder de {quantidadePoder}");
            else if(sucessor != null)
                sucessor.Convoca(quantidadePoder);
        }   
    }
}