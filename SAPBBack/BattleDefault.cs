using System.Collections;
using System.Collections.Generic;

public class BattleDefault : BattleFactory
{
    public Player Player { get; set; }
    public Enemy Enemy { get; set; }
    public Stack<MachinesPrototype> PlayerTeam { get; set; } = null;
    public Stack<MachinesPrototype> EnemyTeam { get; set; } = null;

    public void Attack()
    {
        var CurrentPlayerMachine = PlayerTeam.Peek();
        var CurrentEnemyMachine = EnemyTeam.Peek();
        CurrentPlayerMachine.Life -= CurrentEnemyMachine.Attack;
        CurrentEnemyMachine.Life -= CurrentPlayerMachine.Attack;
        CurrentPlayerMachine.AttackAbility(PlayerTeam, EnemyTeam);
        CurrentEnemyMachine.AttackAbility(EnemyTeam, PlayerTeam);
    }


    public void Kill()
    {
        var CurrentPlayerMachine = PlayerTeam.Peek();
        var CurrentEnemyMachine = EnemyTeam.Peek();
        if (CurrentPlayerMachine.Life < 1)
        {
            CurrentPlayerMachine.DeadAbility(PlayerTeam, EnemyTeam);
            PlayerTeam.Pop();
        }
        if (CurrentEnemyMachine.Life < 1)
        {
            CurrentEnemyMachine.DeadAbility(EnemyTeam, PlayerTeam);
            EnemyTeam.Pop();
        }
    }

    public void NextRound()
    {
        Attack();
        Kill();
    }

    public void BattleBuild()
    {
        this.Player = Game.Current.Player;
        for (int i = Player.Team.Length - 1; i < 0; i--)
        {
            PlayerTeam.Push((MachinesPrototype)Player.Team[i].Clone());
        }
        this.Enemy = Game.Current.Enemy;
        for (int i = Enemy.Team.Length - 1; i < 0; i--)
        {
            EnemyTeam.Push((MachinesPrototype)Enemy.Team[i].Clone());
        }
    }

    public void StartRoundBattle()
    {
        while (PlayerTeam.Count > 0 && EnemyTeam.Count > 0)
        {
            NextRound();
        }
        if (PlayerTeam.Count != 0)
            Game.Current.Player.Trophies += 1;
        else
            Game.Current.Player.Life -= 1;
        EndRoundBattle();
    }

    public void EndRoundBattle()
    {
        if (Player.Life < 1)
            Game.Current.GameEnd();
        Game.Current.StartShopRound();
    }
}
