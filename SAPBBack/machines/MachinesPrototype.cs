using System;
using System.Collections;
using Microsoft.VisualBasic;

public abstract class MachinesPrototype : ICloneable
{
    public abstract int Tier { get; }
    public int Level { get; set; } = 1;
    public int Experience { get; set; } = 1;
    public abstract int Attack { get; set; }
    public abstract int Life { get; set; }
    public virtual int Price { get; protected set; } = 3;
    public abstract object Clone();

    public virtual void RoundShopAbility()
    {
        return;
    }

    public virtual void RoundBattleAbility()
    {
        return;
    }

    public virtual void SellAbility()
    {
        return;
    }

    public virtual void DeadAbility(IEnumerable playerteam, IEnumerable enemyteam)
    {
        return;
    }

    public virtual void AttackAbility()
    {
        return;
    }

    public virtual void LevelUp(int level, int experience)
    {
        level = this.Level;
        experience = this.Experience;
    }
}