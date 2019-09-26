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
            name = "SpaceShip";
            health = 90;
            maxHealth = health;
            fuel = 100;
            maxFuel = fuel;
            isAlive = true;
            throw new NotImplementedException();
        }

        public Spaceship(string _name, int _health, int _fuel)
        {
            name = _name;
            health = _health;
            maxHealth = health;
            fuel = _fuel;
            maxFuel = fuel;
            isAlive = true;
            throw new NotImplementedException();
        }

        public void Hit(int damage)
        {
            health = health - damage;
            throw new NotImplementedException();
        }

        public void Refuel(int fuel)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Repair(int repairValue)
        {
            throw new NotImplementedException();
        }
    }
}
