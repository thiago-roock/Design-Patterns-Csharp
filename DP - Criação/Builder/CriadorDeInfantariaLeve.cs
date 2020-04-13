namespace Builder
{
    public class CriadorDeInfantariaLeve: CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aéreo");
        }

        public override void Transporte(){
            _soldado.EscolherTransporte("Helicoptero de ataque do exército");
        }

        public override void Foco(){
            _soldado.DefinirFoco("resposta rápida aérea");
        }
    }
}