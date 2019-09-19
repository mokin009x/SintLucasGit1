using System;

namespace Spaceship
{
    public enum State
    {
        INIT,
        RUN,
        EXIT
    }
    class Program
    {
        public Fightership[] fighterFleet;
        public Cargoship[] cargoFleet;

        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                State state = State.INIT;

                switch (state)
                {
                    case State.INIT:
                        Init();
                        state = State.RUN;
                        break;
                    case State.RUN:
                        Run();
                        state = State.EXIT;
                        break;
                    case State.EXIT:
                        Exit();
                        exit = true;
                        break;
                    default:
                        break;
                }
            } while (!exit);
        }

        static void Init()
        {
            throw new NotImplementedException();
        }

        static void Run()
        {
            throw new NotImplementedException();
        }

        static void Exit()
        {
            throw new NotImplementedException();
        }
    }
}
