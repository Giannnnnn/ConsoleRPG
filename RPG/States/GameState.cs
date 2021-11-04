using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RPG.States
{
    class GameState : State
    {
        ArrayList characterList;
        public GameState(Stack<State> states, ArrayList character_list) : base(states)
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

                default:
                    break;
            }
        }
        public override void Update()
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Write a number: ");
            GUI.MenuTitle("Game State");
            GUI.MenuOption(1, "Character Created");
            GUI.MenuOption(-1, "Exit");

            GUI.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
            Console.ResetColor();
        }
    }
}
