public class MillingCutter : MachinesPrototype //Fresa
{
    public override int Tier => 4;
    public override int Attack { get; protected set; } = 4;
    public override int Life { get; protected set; } = 5;
    public override object Clone()
    {
        var clone = new MillingCutter();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }
}
