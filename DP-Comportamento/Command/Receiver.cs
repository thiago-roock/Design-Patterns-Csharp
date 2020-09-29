using System;
namespace Command
{
    public class Receiver
    {
        public void PrimeiroPedido(string a)
        {
           Console.WriteLine($"Comando recebido {a}");
        }

        public void SegundoPedido(string b)
        {
           Console.WriteLine($"Outro Comando recebido {b}");
        }
        
    } 

}