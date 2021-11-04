using RPG.Gameplay;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RPG.States
{
    class MainMenuState : State
    {
        protected ArrayList characterList;
        public MainMenuState(Stack<State> states, ArrayList character_list) : base(states)
        {
            this.characterList = character_list;
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    break;
                case 2:
                    this.states.Push(new CharacterCreationState(this.states, this.characterList));

                    break; 
                case 3:
                    Console.WriteLine(this.characterList.Count);
                    break;
                default:
                    break;
            }
        }
        public override void Update()
        {
            GUI.MenuTitle("Game State");
            GUI.MenuOption(1, "New Game ");
            GUI.MenuOption(2, "Create Character ");
            GUI.MenuOption(3, "List Characters ");
            GUI.MenuOption(-1, "Exit");

            GUI.SelectAnOption("Select");
            var input = Convert.ToInt32(Console.ReadLine());


            this.ProcessInput(input);
        }

    }
}
