public class Treadmill : MachinesPrototype
{
    public override int Tier => 1;
    public override int Attack { get; set; } = 3;
    public override int Life { get; set; } = 1;
    public override object Clone()
    {
        var clone = new Treadmill();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }
}