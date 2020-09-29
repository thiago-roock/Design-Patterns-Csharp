using System;
namespace Command
{
    public class Controle
    {
        private ICommand simplesComando;
        private ICommand complexoComando;

        public void EnviarComandoSimples(ICommand command)
        {
            simplesComando = command;
        }

        public void EnviarComandoComplexo(ICommand command)
        {
            complexoComando = command;
        }

        public void Fazer()
        {
           Console.WriteLine($"Ok, vou executar para você!");
           if(simplesComando is ICommand)
              simplesComando.Executar();

           if(complexoComando is ICommand)
              complexoComando.Executar();
        }
    } 
}