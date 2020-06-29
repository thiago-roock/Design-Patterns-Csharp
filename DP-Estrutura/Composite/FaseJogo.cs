using System;

namespace Composite
{
    public class FaseJogo : ComponenteFase
    {

        public FaseJogo(string nome):base(nome)
        {

        }
        public override void Adicionar(ComponenteFase cf)
        {
            Console.WriteLine("Não é possível adicionar a fase no jogo por aqui!");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-',profundidade) + nome);
        }

        public override void Remover(ComponenteFase cf)
        {
            Console.WriteLine("Não é possível remover a fase no jogo por aqui!");
        }
    }
}
