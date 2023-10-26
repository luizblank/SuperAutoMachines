using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
//singleton and builder
public class Shop
{
    private Shop() { }
    private static Shop crr = null;
    public static Shop Current => crr;
    public MachinesPrototype[] CurrentShop = new MachinesPrototype[3];
    public List<MachinesPrototype> StartStorage;
    public List<MachinesPrototype> MidStorage;
    public List<MachinesPrototype> FinalStorage;

    private void Refresh()
    {
        if(Game.Round < 4)
        {
            StartStorage.Sort();
            this.CurrentShop = (MachinesPrototype[])StartStorage.Take(3);
            return;
        }

        else if(Game.Round < 8)
        {
            MidStorage.Sort();
            this.CurrentShop = (MachinesPrototype[])MidStorage.Take(3);
            return;
        }

        else
        {
            FinalStorage.Sort();
            this.CurrentShop = (MachinesPrototype[])FinalStorage.Take(3);
            return;
        }
    }

    public void Buy(int buyid)
    {
        if(Player.Current.Coins < 3)
        {  
            Console.WriteLine("Não é possível comprar com essa quantidade de moedas!");
            return;
        }

        var teamArr = Player.Current.Team;
        int notnull = 0;
        for(int i = 0; i < teamArr.Length; i++)
        {
            if(teamArr[i] == null)
            {
                Player.Current.Team[i] = CurrentShop[buyid - 1];
                Player.Current.Coins -= 3;
                CurrentShop[i] = null;
                return;
            }
            notnull += 1;
        }

        if(notnull == teamArr.Length)
            Console.WriteLine("Seu time está lotado! Venda uma máquina para comprar uma nova.");
    }

    public void SellMachine(MachinesPrototype machine)
    {
        Player.Current.Coins += 1;
        machine.SellAbility();
        return;
    }

    public static void Reset()
        => crr = new Shop();
        
    public class ShopBuilder
    {
        private Shop shop = new Shop();
        public Shop Build()
            => this.shop;

        public ShopBuilder SetStartStorage(MachinesPrototype[] machines)
        {
            foreach(MachinesPrototype machine in machines)
                this.shop.StartStorage.Add(machine);
            return this;
        }

        public ShopBuilder SetMidStorage(MachinesPrototype[] machines)
        {
            foreach(MachinesPrototype machine in machines)
                this.shop.StartStorage.Add(machine);
            return this;
        }

        public ShopBuilder SetFinalStorage(MachinesPrototype[] machines)
        {
            foreach(MachinesPrototype machine in machines)
                this.shop.StartStorage.Add(machine);
            return this;
        }

        public static ShopBuilder GetBuilder()
            => new ShopBuilder();

        public static void New(ShopBuilder builder)
            => crr = builder.Build();
    }
}

