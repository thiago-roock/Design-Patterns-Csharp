using System;
namespace Visitor
{
    public class NivelVisitor: IVisitor
    {
        public void Identificar(FaseJogo fase)
        {
            switch(fase.NomeFase)
            {
                case "Floresta" : { Console.WriteLine($"A fase {fase.NomeFase} no jogo é {70}% dificil"); break; }
                case "Caverna" :  { Console.WriteLine($"A fase {fase.NomeFase} no jogo é {30}% dificil"); break; }
            }
        }
        public void Identificar(Chefao chefao)
        {
            switch(chefao.NomeChefao)
            {
                    case "Boss 1" :
                    {
                        Console.WriteLine($"O Chefão {chefao.NomeChefao} é {25}% dificil e tem {chefao.PontosVida} pontos de vida.");
                        break;
                    }
                    case "Boss 2":
                    { 
                        Console.WriteLine($"O Chefão {chefao.NomeChefao} é {50}% dificil e tem {chefao.PontosVida} pontos de vida.");
                        break;
                    }
            }
        }
        
    }
}