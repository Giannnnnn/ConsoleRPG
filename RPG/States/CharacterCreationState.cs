using RPG.Gameplay;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RPG.States
{
    class CharacterCreationState : State
    {
        ArrayList characterList;

        public CharacterCreationState(Stack<State> states, ArrayList character_list) : base(states)
        {
            this.characterList = character_list;
        }


        //private methods
        private void CreateCharacter(int input)
        {


            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    String name = "";
                    String description = "";
                    GUI.GetInput("Input the character name: ");
                    name = Console.ReadLine();
                    GUI.GetInput("Input the character description for " + name);
                    description = Console.ReadLine();
                    this.characterList.Add(new Character(name, description));
                    break;

                default:
                    break;
            }
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;
                case 1:
                    this.CreateCharacter(1);
                    break;

                default:
                    break;
            }
        }

        public override void Update()
        {
            GUI.CharacterCreationTitle("Character Menu:");
            GUI.MenuOption(1, "New Character");
            GUI.MenuOption(2, "Edit Character");
            GUI.MenuOption(3, "Delete");
            GUI.MenuOption(-1, "Exit");

            GUI.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }
    }
}
