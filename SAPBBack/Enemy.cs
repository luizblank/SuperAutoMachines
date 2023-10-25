using System.Collections.Generic;
//singleton
public class Enemy
{
    private Enemy() { }
    private static Enemy crr = null;
    public static Enemy Current => crr;
    public Stack<MachinesPrototype> Team = new();

    private void RandomTeam()
    {
        return;
    }

    public static void Reset()
        => crr = new Enemy();
}