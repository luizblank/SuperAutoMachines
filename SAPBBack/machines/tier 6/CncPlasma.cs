public class CncPlasma : MachinesPrototype //Corte a Plasma CNC
{
    public override int Tier => 6;
    public override int Attack { get; protected set; } = 6;
    public override int Life { get; protected set; } = 8;

    public override object Clone()
    { 
       var clone  = new CncPlasma();
       clone.Level = this.Level;
       clone.Attack = this.Attack;
       clone.Life = this.Life;
       clone.Experience = this.Experience;
       return clone;
    }
}
