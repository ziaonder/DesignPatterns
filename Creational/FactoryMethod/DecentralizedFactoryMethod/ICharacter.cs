public interface ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public string AttackType { get; set; }
    public void Attack();
}
