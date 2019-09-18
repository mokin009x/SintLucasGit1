using System;
using System.Collections.Generic;
using System.Text;

namespace Spaceship
{
    struct Cargo
    {
        public string name;
        public int health;
        public int fuel;
        public int cargospace;
    }
    class Cargoship : Spaceship
    {
        private int Cargospace;
        private int usedCargospace;

        public Cargoship()
        {
            throw new NotImplementedException();
        }

        public Cargoship(ref Cargo cargo)
            : base(cargo.name, cargo.health, cargo.fuel)
        {
            throw new NotImplementedException();
        }

        public void LoadCargo(int cargo)
        {
            throw new NotImplementedException();
        }

        public void UnloadCargo(int cargo)
        {
            throw new NotImplementedException();
        }
    }
}
