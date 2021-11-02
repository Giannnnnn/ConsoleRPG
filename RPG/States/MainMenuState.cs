using RPG.Gameplay;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.States
{
    class MainMenuState : State
    {
        public MainMenuState(Stack<State> states) : base(states)
        {
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 0:
                    break;
                case 1:
                    this.states.Push(new CharacterCreationState(this.states));

                    break;
                default:
                    break;
            }
        }
        public override void Update()
        {
            Console.Write(GUI.MenuTitle("Game State"));
            Console.Write(GUI.MenuOption(0, "New Game "));
            Console.Write(GUI.MenuOption(1, "Create Character "));
            Console.Write(GUI.MenuOption(-1, "Exit"));

            Console.WriteLine("Write a number: ");
            int input = Convert.ToInt32(Console.ReadLine());


            this.ProcessInput(input);
        }

    }
}
