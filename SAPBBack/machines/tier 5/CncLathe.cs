public class CncLathe : MachinesPrototype //Corte a Plasma CNC
{
    public override int Tier => 5;
    public override int Attack { get; set; } = 5;
    public override int Life { get; set; } = 8;
    public override object Clone()
    {
        var clone = new CncLathe();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }

}
