public class Hammer : MachinesPrototype
{
    public override int Tier => 1;
    public override int Attack { get; set; } = 2;
    public override int Life { get; set; } = 3;
    public override object Clone()
    {
        var clone = new Hammer();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }

    public override void SellAbility()
    {
        foreach(var item in Shop.Current.CurrentShop)
        {
            item.Life += 1;
        }
    }
}