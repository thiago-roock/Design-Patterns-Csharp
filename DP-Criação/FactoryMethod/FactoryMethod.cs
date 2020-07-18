namespace FactoryMethod
{
    public class FactoryMethod
    {
        public IPersonagem Escolher_Personagem(string personagem)
        {
            return personagem switch
            {
                "Ryu" => new Ryu(),
                "Ken" => new Ken(),
                "Chun li" => new ChunLi(),
                _ => null,
            };
        }
    }
}
