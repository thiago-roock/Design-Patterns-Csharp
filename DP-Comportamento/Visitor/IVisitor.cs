using System;
namespace Visitor
{
    public interface IVisitor
    {
        void Identificar(Chefao chefao);
        void Identificar(FaseJogo faseJogo);
    }
}