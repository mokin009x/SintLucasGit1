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
            throw new NotImplementedException();
        }

        public Fightership(ref Fighter fighter)
            : base(fighter.name, fighter.health, fighter.fuel)
        {
            throw new NotImplementedException();
        }

        public int Shoot()
        {
            throw new NotImplementedException();
        }

        public void Reload(int ammo)
        {
            throw new NotImplementedException();
        }
    }
}
