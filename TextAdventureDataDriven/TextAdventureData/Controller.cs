using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureData
{
    class Controller
    {
        private static Controller uniqueinstance = new Controller();
        public static Controller getinstancec()
        {
            return uniqueinstance;
        }
        public string Input()
        {

            string choice;
            Console.Write("Your choice : ");
            choice = Console.ReadLine().ToLower();
            return choice;

        }
    }
}

