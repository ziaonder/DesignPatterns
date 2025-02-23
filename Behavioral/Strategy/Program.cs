namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(new MagicAttack());
            player.Attack();
            player.SetAttackStrategy(new RangedAttack());
            player.Attack();
            player.SetAttackStrategy(new MeleeAttack());
            player.Attack();
        }
    }
}
