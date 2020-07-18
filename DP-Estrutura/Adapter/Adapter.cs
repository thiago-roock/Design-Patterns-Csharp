using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adapter:IAcao
    {
        Aviao aviao;

        public Adapter(Aviao novo_aviao)
        {
            this.aviao = novo_aviao;
        }

        public void Andar(string personagem)
        {
            this.aviao.Voar("Thiago");
        }

        public void Atirar()
        {
            this.aviao.SoltarMissil();
        }
    }
}
