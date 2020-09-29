using System;
namespace Command
{
    public class ComplexoComando : ICommand
    {
        private Receiver _receive;
        private string _a = string.Empty;
        private string _b = string.Empty;


        public ComplexoComando(Receiver receive,string a, string b){
            _receive = receive;
            _a = a;
            _b = b;

        }

        public void Executar()
        {
            _receive.PrimeiroPedido(_a);
            _receive.SegundoPedido(_b);
        }
    }
}