using System;

public class WarriorFactory : AbstractCharacterFactory
{
    public override Character CreateCharacter()
    {
        return new Warrior();
    }
}
