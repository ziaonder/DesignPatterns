using System;

public class MageFactory : AbstractCharacterFactory
{
    public override Character CreateCharacter()
    {
        return new Mage();
    }
}
