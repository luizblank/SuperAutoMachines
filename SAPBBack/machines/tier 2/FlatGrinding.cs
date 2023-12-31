public class FlatGrinding : MachinesPrototype
{
    public override int Tier => 2;
    public override int Attack { get; set; } = 4;
    public override int Life { get; set; } = 2;
    public override object Clone()
    {
        var clone = new FlatGrinding();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }
}