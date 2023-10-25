using System.Collections.Generic;

public class Player
{
    private Player() { }

    private static Player crr = null;

    public static Player Current => crr;
    
    public int Life { get; set; }
    public int Coins { get; set; }
    public int Trophies { get; set; }
    public MachinesPrototype Team = new MachinesPrototype[5];

    public static void Reset()
        => crr = new Player();
}