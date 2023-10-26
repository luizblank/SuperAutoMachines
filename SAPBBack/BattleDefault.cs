using System.Collections;
using System.Collections.Generic;

public class BattleDefault : BattleFactory
{
    public Player Player { get; set; }
    public Enemy Enemy { get; set; }
    public Stack<MachinesPrototype> PlayerTeam {get;set;} = null;
    public Stack<MachinesPrototype> EnemyTeam {get;set;} = null;

    public void Attack()
    {
       var CurrentPlayerMachine = PlayerTeam.Peek();
       var CurrentEnemyMachine = EnemyTeam.Peek();
    }


    public void Kill()
    {
        
    }

    public void NextRound()
    {
        
    }

    public void StartBattle(Player player, Enemy enemy)
    {
        this.Player = player;
        for (int i = player.Team.Length-1; i < 0 ; i--)
        {
            PlayerTeam.Push(player.Team[i]);
        }
        this.Enemy = enemy;
        for (int i = enemy.Team.Length-1; i < 0 ; i--)
        {
            EnemyTeam.Push(enemy.Team[i]);
        }
        Attack();
    }
    public void EndBattle()
    {
        
    }
}