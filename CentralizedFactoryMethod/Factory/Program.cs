using System;

public class Program
{
    public static void Main(string[] args)
    {
        GameCharacterFactory factory = new GameCharacterFactory();

        ICharacter archer = factory.CreateCharacter("archer");
        archer.DisplayStats();

        ICharacter warrior = factory.CreateCharacter("warrior");
        warrior.DisplayStats();

        ICharacter mage = factory.CreateCharacter("mage");
        mage.DisplayStats();
    }
}

