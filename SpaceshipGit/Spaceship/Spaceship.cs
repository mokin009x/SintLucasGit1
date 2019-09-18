using System;
using System.Collections.Generic;
using System.Text;

namespace Spaceship
{
    abstract class Spaceship
    {
        protected string name;
        protected int health;
        protected int maxHealth;
        protected int fuel;
        protected int maxFuel;
        protected bool isAlive;

        public Spaceship()
        {
            throw new NotImplementedException();
        }

        public Spaceship(string name, int health, int fuel, bool isAlive)
        {
            throw new NotImplementedException();
        }

        public void Hit(int damage)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
