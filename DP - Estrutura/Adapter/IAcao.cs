using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IAcao
    {
        void Andar(string jogador);
        void Atirar();
    }
}
