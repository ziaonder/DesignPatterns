using System;

public class Program
{
    public static void Main(string[] args)
    {
        ICharacterFactory warriorFactory = new WarriorFactory();
        ICharacter warrior = warriorFactory.CreateCharacter();
        warrior.Attack();

        ICharacterFactory mageFactory = new MageFactory();
        ICharacter mage = mageFactory.CreateCharacter();
        mage.Attack();

        ICharacterFactory archerFactory = new ArcherFactory();
        ICharacter archer = archerFactory.CreateCharacter();
        archer.Attack();
    }
}