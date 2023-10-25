public class GasFurnace : MachinesPrototype
{
    public override int Tier => 2;
    public override int Attack { get; protected set; } = 1;
    public override int Life { get; protected set; } = 3;
    public override object Clone()
    {
        var clone = new GasFurnace();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }
    public override void RoundShopAbility()
    {
        Player.Current.Coins += 1;
        return;
    }
}
