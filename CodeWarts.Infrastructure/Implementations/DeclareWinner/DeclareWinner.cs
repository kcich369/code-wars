namespace CodeWarts.Infrastructure.Implementations.DeclareWinner;

public class DeclareWinner
{
    public static string Fight(Fighter fighter1, Fighter fighter2, string firstAttacker)
    {
        var fighters = new List<Fighter>() { fighter1, fighter2 };
        var attacker = fighters.Single(x => x.Name == firstAttacker);
        var defender = fighters.First(x => x.Name != firstAttacker);
        do
        {
            Fight(attacker, defender);
            (defender, attacker) = (attacker, defender);
        } while (attacker.Health > 0 && defender.Health > 0);

        return fighters.First(x => x.Health > 0).Name;
    }

    private static void Fight(Fighter attacker, Fighter defender)
    {
        if (attacker.Name == defender.Name)
            throw new ArgumentException("It is the same fighter, choose other");
        defender.Health -= attacker.DamagePerAttack;
    }
}

public class Fighter
{
    public string Name;
    public int Health, DamagePerAttack;

    public Fighter(string name, int health, int damagePerAttack)
    {
        this.Name = name;
        this.Health = health;
        this.DamagePerAttack = damagePerAttack;
    }
}