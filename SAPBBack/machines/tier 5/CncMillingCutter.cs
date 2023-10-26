public class CncMillingCutter : MachinesPrototype //Fresa CNC
{
    public override int Tier => 5;
    public override int Attack { get; set; } = 8;
    public override int Life { get; set; } = 4;

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
