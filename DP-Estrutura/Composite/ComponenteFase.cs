namespace Composite
{
    public abstract class ComponenteFase
    {
        protected string nome;

        public ComponenteFase(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(ComponenteFase cf);
        public abstract void Remover(ComponenteFase cf);
        public abstract void Mostrar(int profundidade);
    }
}
