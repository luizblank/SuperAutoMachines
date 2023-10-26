using System.Collections.Generic;
//singleton
public class Enemy
{
    private Enemy() { }
    private static Enemy crr = null;
    public static Enemy Current => crr;
    public MachinesPrototype[] Team = new MachinesPrototype[5];

    private void RandomTeam()
    {
        return;
    }

    public static void Reset()
        => crr = new Enemy();
}