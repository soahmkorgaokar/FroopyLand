using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureData
{
    public class Globals
    {
        //public static int keys = 0;
        public static int currentroom = 1;


    }

    class Adventure
    {
        private static Adventure uniqueinstance = new Adventure();
        public static Adventure getinstancea()
        {
            return uniqueinstance;
        }
        static void Main(string[] args)
        {
            View.getinstancev().Intro();
            bool mygame = false;
            while (!mygame)
            {

                View.getinstancev().Options();
                string Todo = Controller.getinstancec().Input();

                if (Todo == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    string op = GameLogic.getinstanceg().Move(Globals.currentroom, Todo);
                    View.getinstancev().PassHere(op);
                    //Console.Clear();
                }

            }

        }
    }
}
