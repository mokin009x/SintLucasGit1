using System;
using System.Collections.Generic;
using System.Text;

namespace Spaceship
{
    struct Fighter
    {
        public string name;
        public int health;
        public int fuel;
        public int ammo;
        public int guns;
    }
    class Fightership : Spaceship
    {
        private int ammo;
        private int maxAmmo;
        private int guns;

        

        public Fightership()
            : base()
        {
            ammo = 5;
            maxAmmo = 15;
            guns = 1;
        }

        public Fightership(ref Fighter fighter)
            : base(fighter.name, fighter.health, fighter.fuel)
        {
            Fighter f = new Fighter();
            f.name = "Weirdoo";
            f.health = 20;
            f.fuel = 100;
            Fightership f1 = new Fightership(ref f);
        }

        public int Shoot()
        {
            Fighter f = new Fighter();
            if (ammo > 0)
            {
                f.health = (f.health - 2);
                f.ammo--;
                Fightership f1 = new Fightership(ref f);
            }
            else
            {
                Console.WriteLine("Not enough ammo");
            }
            return f.health;
        }

        public void Reload(int ammo)
        {
            throw new NotImplementedException();
        }
    }
}
