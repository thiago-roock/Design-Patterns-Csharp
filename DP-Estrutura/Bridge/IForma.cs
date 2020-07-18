using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public interface IForma
    {
        string Descer();
        ICor ICor { get; set; }
    }
}
