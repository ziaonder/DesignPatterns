using System;

public class ArcherFactory : AbstractCharacterFactory
{
    public override Character CreateCharacter()
    {
        return new Archer();
    }
}
