using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Composite : ComponenteFase
    {
        private List<ComponenteFase> fases = new List<ComponenteFase>();

        public Composite(string nome) : base(nome)
        {

        }
        public override void Adicionar(ComponenteFase cf)
        {
            this.fases.Add(cf);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);
            foreach(ComponenteFase fase in this.fases)
            {
                fase.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(ComponenteFase cf)
        {
            this.fases.Remove(cf);
        }
    }
}
