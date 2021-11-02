﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.States
{
    class GameState : State
    {

        public GameState(Stack<State> states) : base(states)
        {

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
            Console.WriteLine("Write a number: ");
            Console.Write(GUI.MenuTitle("Game State"));

            Console.Write(GUI.MenuOption(0, "Character Created"));
            Console.Write(GUI.MenuOption(-1, "Exit"));

            GUI.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }
    }
}
