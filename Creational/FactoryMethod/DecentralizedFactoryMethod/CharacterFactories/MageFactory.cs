using System;

public class MageFactory : ICharacterFactory
{
    public ICharacter CreateCharacter()
    {
        return new Mage();
    }
}
