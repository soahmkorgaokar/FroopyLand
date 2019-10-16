using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureData
{
    class View
    {
        private static View uniqueinstancev = new View();
        public static View getinstancev()
        {
            return uniqueinstancev;
        }
        public void PassHere(string abc)
        {
            Console.WriteLine(abc);
        }
        public void Invalid()
        {
            Console.WriteLine("No exits in this direction");
        }
        public void Intro()
        {
            Console.WriteLine("Welcome to the game. \nYou are stuck in a room with a lit candle, " +
                    "figuring a way out of an old scary house.\n" +
                    "Visit rooms to find special objects \n" +
                    "May the odds be in your favour.\n" +
                    "Press Enter to Continue \n" +
                    "===============================================");
            Console.ReadKey();
        }

        public void Options()
        {
            Console.WriteLine("\n===============================================" +
                "\nWhat do you want to do? \n(Type the character in the brackets)" +
              "\n\n" +
              "Look around (look)\n" +
              "Head North (n) \n" +

              "Head East (e) \n" +

              "Head West (w) \n" +

              "Head South (s) \n" +
              "Quit Game (q) \n");
        }
    }
}
