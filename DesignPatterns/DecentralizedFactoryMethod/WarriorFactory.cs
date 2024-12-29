public class WarriorFactory : ICharacterFactory
{
    public ICharacter CreateCharacter()
    {
        return new Warrior();
    }
}

