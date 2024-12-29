public interface ICharacter
{
    string Name { get; set; }
    int Health { get; set; }
    string AttackType { get; set; }

    void DisplayStats();
}
