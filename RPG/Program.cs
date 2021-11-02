using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine(GUI.Title("WELCOME FILHA DA PUTA"));
            game.Run();
        }
    }
}
