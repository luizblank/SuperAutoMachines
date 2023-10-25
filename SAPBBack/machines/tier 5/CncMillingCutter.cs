public class CncMillingCutter : MachinesPrototype //Fresa CNC
{
    public override int Tier => 5;
    public override int Attack { get; protected set; } = 8;
    public override int Life { get; protected set; } = 4;

    public override object Clone()
    {
        var clone = new CncMillingCutter();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }
}
