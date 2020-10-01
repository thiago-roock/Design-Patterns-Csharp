using System;
namespace Strategy
{
    public class Papagaio: IAjuda
    {
        public string Ajudar(Ajuda pedido){
            return "Sou um papagaio e posso ajudar você a voar";
        }
    }
}