public class ElectricFurnace : MachinesPrototype
{
    public override int Tier => 3;

    public override int Attack { get; protected set; } = 4;
    public override int Life { get; protected set; } = 3;

    public override object Clone()
    {
        var clone = new ElectricFurnace();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }
}
