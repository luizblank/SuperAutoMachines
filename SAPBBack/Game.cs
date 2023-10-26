using System;

public class Game
{
    private Game() { }
    private static Game crr = null;
    public static Game Current => crr;
    public static int Round { get; set; } = 0;
    public Player Player = null;
    public Enemy Enemy = null;
    public Shop Shop = null;
    public BattleFactory Battle = null;
    public static void Reset()
        => crr = new Game();
    public void StartShopRound()
    {
        Console.WriteLine(Shop);
        // if (keypress == espaço){
        //     EndShopRound();
        // }
    }
    public void EndShopRound()
    {
        foreach (var machine in this.Player.Team)
        {
            machine.RoundShopAbility();
        }
        Battle.StartRoundBattle();  
    }

    public void GameEnd()
    {
        if(this.Player.Life <= 0)
        {
            Console.WriteLine("Você Perdeu!");
        }
    }

    public void GameStart()
    {
        StartShopRound();
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
        public Game SetBattle(BattleFactory battle)
        {
            this.game.Battle = battle;
            return this.game;
        }
        public GameBuilder GetBuilder()
            => new GameBuilder();
        
        public void New(GameBuilder builder)
            => crr = builder.Build();
    }
}
