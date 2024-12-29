public class Program
{
    public static void Main(string[] args)
    {
        AbstractCharacterFactory archerFactory = new ArcherFactory();
        Character archer = archerFactory.CreateCharacter();
        archer.Attack();

        AbstractCharacterFactory mageFactory = new MageFactory();
        Character mage = mageFactory.CreateCharacter();
        mage.Attack();

        AbstractCharacterFactory warriorFactory = new WarriorFactory();
        Character warrior = warriorFactory.CreateCharacter();
        warrior.Attack();
    }
}