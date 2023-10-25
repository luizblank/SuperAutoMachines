public class ColDrill : MachinesPrototype
{
    public override int Tier => 2;

    public override int Attack { get; protected set; } = 3;

    public override int Life {get; protected set;} = 5;

    public override object Clone()
    {
        var clone = new ColDrill();
        clone.Level = this.Level;
        clone.Attack = this.Attack;
        clone.Life = this.Life;
        clone.Experience = this.Experience;
        return clone;
    }
}
