using System;

public class ArcherFactory : ICharacterFactory
{
    public ICharacter CreateCharacter()
    {
        return new Archer();
    }
}
