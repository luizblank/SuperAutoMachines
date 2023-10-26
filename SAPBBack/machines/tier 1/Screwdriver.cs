using System;

public class Screwdriver : MachinesPrototype
{
    public override int Tier => 1;
    public override int Attack { get; set; } = 2;
    public override int Life { get; set; } = 3;
    public override object Clone()
    {
        var clone = new Screwdriver();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }

    public override void SellAbility()
    {
        Random random = new Random();
        int randId = random.Next(Player.Current.Team.Length);
        Player.Current.Team[randId].Life += 1;
    }
}
