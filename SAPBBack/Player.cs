using System.Collections.Generic;

public class Player
{
    private Player() { }

    private static Player crr = null;

    public static Player Current => crr;
    
    public int Life { get; set; } = 5;
    public int Coins { get; set; } = 10;
    public int Trophies { get; set; } = 0;
    public MachinesPrototype[] Team = new MachinesPrototype[5];

    public static void Reset()
        => crr = new Player();
    
}