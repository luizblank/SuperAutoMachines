using System.Runtime.CompilerServices;

public class Lathe : MachinesPrototype
{
    public override int Tier => 4;
    public override int Attack { get; set; } = 5;
    public override int Life { get; set; } = 3;
    public override object Clone()
    {
        var clone = new Lathe();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }

    public override void RoundBattleAbility()
    {
        foreach(MachinesPrototype item in Player.Current.Team)
        {
            if (item.Level == 3)
            {
                this.Attack += 2;
                this.Life += 2;
                return;
            }
        }

        return;
    }
}
