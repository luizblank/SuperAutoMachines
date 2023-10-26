using System;

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

    public void ShopRound()
    {
        
        BattleDefault.Current.StartBattle();  
    }

    public void GameEnd()
    {
        if(Player.Current.Life <= 0)
        {
            Console.WriteLine("Você Perdeu!");
        }
    }

    public void GameStart()
    {
        ShopRound();
    }

    public class GameBuilder
    {
        private Game game = new Game();
        public Game Build()
            => this.game;
        public Game SetPlayer(Player player)
        {
            this.game.Player = player;
            return this.game;
        }
        public Game SetEnemy(Enemy enemy)
        {
            this.game.Enemy = enemy;
            return this.game;
        }
        public Game SetShop(Shop shop)
        {
            this.game.Shop = shop;
            return this.game;
        }
        public GameBuilder GetBuilder()
            => new GameBuilder();
        
        public void New(GameBuilder builder)
            => crr = builder.Build();
    }
}
