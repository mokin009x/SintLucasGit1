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

        public Spaceship(string name, int health, int fuel)
        {
            this.name = name;
            this.health = health;
            maxHealth = health;
            this.fuel = fuel;
            maxFuel = fuel;
            isAlive = true;
            throw new NotImplementedException();
        }

        public void Hit(int damage)
        {
            
            if (health - damage <= 0)
            {
                isAlive = false;
            }
            else
            {
                health =- damage;
            }
           
            throw new NotImplementedException();
        }

        public void Refuel(int fuel)
        {
            if (this.fuel < maxFuel)
            {
                this.fuel += fuel;

            }
            throw new NotImplementedException();
        }

        public void Move()
        {
            if (fuel > 0)
            {
                fuel = fuel - 2;
            }
          
            throw new NotImplementedException();
        }
       
        public void Repair(int repairValue)
        {
            throw new NotImplementedException();
        }
    }
}
