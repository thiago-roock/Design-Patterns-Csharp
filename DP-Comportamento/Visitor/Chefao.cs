using System;
namespace Visitor
{
    public class Chefao: IJogo
    {
        public string NomeChefao { get; set; }
        public int PontosVida { get; set; }

        public void Visitante(IVisitor visitor){
            visitor.Identificar(this);
        }
    }
}