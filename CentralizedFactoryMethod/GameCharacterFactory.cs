using System; 

public class GameCharacterFactory
{
    public ICharacter CreateCharacter(string name)
    {
        return name.ToLower() switch
        {
            "mage" => new Mage(),
            "warrior" => new Warrior(),
            "archer" => new Archer(),
            _ => throw new NotImplementedException(),
        };
    }
}

