using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class GUI
    {
        public static void Title(String str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            str = String.Format("==== {0} ==== \n \n", str);
            Console.Write(str);
            Console.ResetColor();
        } 
        public static void SelectAnOption(String str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            str = String.Format("==== {0} ==== \n \n", str);
            Console.Write(str);
            Console.ResetColor();
        }
        public static void End(String str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            str = String.Format("==== {0} ==== \n \n", str);
            Console.Write(str);
            Console.ResetColor();
        }
        public static void MenuTitle(String str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            str = String.Format("==== {0} ====  \n ", str);
            Console.Write(str);
            Console.ResetColor();

        }
        public static void MenuOption(int index, String str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            str = String.Format("\t - ({0}) :  {1} - \n", index, str);
            Console.Write(str);
            Console.ResetColor();

        }
        public static void Announcement(String str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            str = String.Format("\t (~) {0}! \n", str);
            Console.Write(str);
            Console.ResetColor();
        } 
        public static void CharacterCreationTitle(String str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            str = String.Format("|============ == = {0} = == ============| \n", str);
            Console.Write(str);
            Console.ResetColor();
        }
        public static void GetInput(String str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            str = String.Format(" - {0}:", str);
            Console.Write(str);
            Console.ResetColor();
        }  
        public static void GetDescription(String str, String name)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            str = String.Format(" - {0} {1}:", str, name);
            Console.Write(str);
            Console.ResetColor();
        }
    }
}
