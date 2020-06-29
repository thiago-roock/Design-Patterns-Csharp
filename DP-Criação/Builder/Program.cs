using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var Exercito = new Exercito();
            CriadorDeSoldado criadorDeSoldado;
            Soldado soldado;

            //criando um soldado das forças especiais
            criadorDeSoldado = new CriadorDeForcasEspeciais();
            Exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado com as características: {0},{1},{2}",
            soldado.Arma,soldado.Transporte,soldado.Foco);

            criadorDeSoldado = new CriadorDeInfantariaLeve();
            Exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado com as características: {0},{1},{2}",
            soldado.Arma,soldado.Transporte,soldado.Foco);
        }
    }
}
