public class CylindricalGrinding : MachinesPrototype
{
    public override int Tier => 3;
    public override int Attack { get; protected set; } = 2;
    public override int Life { get; protected set; } = 6;


    public override object Clone()
    {
        var clone = new CylindricalGrinding();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }
}