using System.Collections.Generic;

public class Player
{   
    public int Life { get; set; } = 5;
    public int Coins { get; set; } = 10;
    public int Trophies { get; set; } = 0;
    public MachinesPrototype[] Team = new MachinesPrototype[5];   
}