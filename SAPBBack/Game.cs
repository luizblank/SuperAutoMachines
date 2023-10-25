public class Game
{
    private Game() { }
    private static Game crr = null;
    public static Game Current => crr;
    public static int Round { get; set; } = 0;
    public Player Player = null;
    public Enemy Enemy = null;
    public Shop shop = null;
    public static void Reset()
        => crr = new Game();
}
