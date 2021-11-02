using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.States
{
    class State
    {
        public Stack<State> states;
        protected bool end = false;

        public State(Stack<State> states)
        {
            this.states = states;
            
        }
        
        public bool EndRequest()
        {
            return this.end;
        }

        virtual public void Update()
        {

        }
    }
}
