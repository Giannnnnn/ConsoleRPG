using RPG.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Game
    {
        public bool end { get; set; }
        public Stack<State> states { get; set; }
        private void InitVariables()
        {
            this.end = false;
        }
        private void InitStates()
        {
            this.states = new Stack<State>();
            this.states.Push(new MainMenuState(this.states));
            //this.states.Push(new GameState(this.states));
        }

        public Game()
        {
            this.InitVariables();
            this.InitStates();
        }

        public void Run()
        {
            while (this.states.Count > 0)
            {
                if (this.states.Count > 0)
                {
                 
                    this.states.Peek().Update();

                    if (this.states.Peek().EndRequest())
                    {
                        this.states.Pop(); 
                    }
                }
            }

            Console.WriteLine("Ending Game...");
        }


    }

}
