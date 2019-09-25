using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class View
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
          "Exit Game (exit) \n");
    }
}



namespace textAdv
{
    static class Globals
    {
        public static int keys = 0;
        public static int curr = 1;


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

                if (Todo == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    string op = GameLogic.getinstanceg().Move(Globals.curr,Todo);
                    View.getinstancev().PassHere(op);
                    //Console.Clear();
                }
                
            }

        }
    }


 

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

    abstract class Room
    {
        //public string name { get; set;}
        public string Invalid()
        {
            string inv = "No exits in this direction";
            return inv;
        }

       
    }

    class Room1 : Room
    {
        public string Des()
        {
            string desc = "The room is filled with filthy shoes and footwear.\n " +
         "It is difficult walking through the mess.\n" +
         "\nThe room has only one exit to the East.\n";
            return desc;
        }
       /* public string Invalid1()
        {
            string inv = "No exits in this direction";
            return inv;
        }*/



    }
    class Room2 : Room
    {
        public string Des()
        {
            string desc = "*Squeeky sound of the door closing behind you*\n" +
            "The room has a distinct smell and is covered with cobwebs.\n" +
            "You enter the room and you can see three doors to three different rooms\n" +
            "in the directions of north, east and south.";
            return desc;
        }


    }
    class Room3 : Room
    {
        public string Des()
        {
            string desc = "*Squeeky sound of the door closing behind you*\n" +
            "The room has an old desk in one of the corners of the room\n" +
            "You go to the desk and have a peekin the drawers and....\n" +
            " Alas, it's empty!!!\n" +
            "There is only one exit to the room, which will be heading North \n";
            return desc;
        }

    }
    class Room4 : Room
    {
        public string Des()
        {
            string desc = "*Squeeky sound of the door closing behind you*\n" +
            "You enter the room and it is chaos. The furniture in the room is broken\n" +
            "and has fungus growing on it\n" +
            "There are rays of light entering the room through gaps in the ceiling\n" +
            "You look around and see a ray of light bouncing from an object in the room\n" +
            "Being very cautious, you approach the object and find it to be a Gold Coin\n" +
            "\nHURRAY!!\n" +
            "There is only one exit to the room, heading west.\n";
            return desc;
        }


    }
    class Room5 : Room
    {
        public string Des()
        {
            string desc = "*Squeeky sound of the door closing behind you*\n" + 
                "Oops, the candle burned out. Now, you have to select the directions by trial\n " +
            "and error to find the red door.\n";
            return desc;
        }

    }
    class Room6 : Room
    {
        public string Des()
        {
            string desc = "Congratulations, you opened the red door. You are free.\n\n" +
                "EXIT THE GAME\n";
            return desc;
        }

    }


    class GameLogic
    {

        private static GameLogic uniqueinstance = new GameLogic();
        public static GameLogic getinstanceg()
        {
            return uniqueinstance;
        }


        public string Move(int curr , string comm)
        {
            //room1
            if (curr == 1 && comm == "look")
            {
                Room1 r1 = new Room1();
                string ans = r1.Des();
                //Console.WriteLine(ans);
                return ans;
            }
            else if (curr == 1 && comm == "n")
            {
                Room1 r1 = new Room1();
                string ans = r1.Invalid();
                return ans;
            }
            else if (curr == 1 && comm == "e")
            {
                Globals.curr = 2;
                string ans = "You enter another room";
                return ans;
            }
            else if (curr == 1 && comm == "w")
            {
                Room1 r1 = new Room1();
                string ans = r1.Invalid();
                return ans;
            }
            else if (curr == 1 && comm == "s")
            {
                Room1 r1 = new Room1();
                string ans = r1.Invalid();
                return ans;
            }

            //room2
            else if (curr == 2 && comm == "look")
            {
                Room2 r1 = new Room2();
                string ans = r1.Des();
                //Console.WriteLine(ans);
                return ans;
            }
            else if (curr == 2 && comm == "n")
            {
                Globals.curr = 5;
                string ans = "You enter another room";
                return ans;
            }
            else if (curr == 2 && comm == "e")
            {
                Globals.curr = 4;
                string ans = "You enter another room";
                return ans;
            }
            else if (curr == 2 && comm == "w")
            {
                Globals.curr = 1;
                string ans = "You enter another room";
                return ans;
            }
            else if (curr == 2 && comm == "s")
            {
                Globals.curr = 3;
                string ans = "You enter another room";
                return ans;
            }

            //room3
            if (curr == 3 && comm == "look")
            {
                Room3 r1 = new Room3();
                string ans = r1.Des();
                //Console.WriteLine(ans);
                return ans;
            }
            else if (curr == 3 && comm == "n")
            {
                Globals.curr = 2;
                string ans = "You enter another room";
                return ans; 
            }
            else if (curr == 3 && comm == "e")
            {
                Room3 r1 = new Room3();
                string ans = r1.Invalid();
                return ans;
            }
            else if (curr == 3 && comm == "w")
            {
                Room3 r1 = new Room3();
                string ans = r1.Invalid();
                return ans;
            }
            else if (curr == 3 && comm == "s")
            {
                Room3 r1 = new Room3();
                string ans = r1.Invalid();
                return ans;
            }


            //Room4
            if (curr == 4 && comm == "look")
            {
                Room4 r1 = new Room4();
                string ans = r1.Des();
                //Console.WriteLine(ans);
                return ans;
            }
            else if (curr == 4 && comm == "n")
            {
                Room4 r1 = new Room4();
                string ans = r1.Invalid();
                return ans;
            }
            else if (curr == 4 && comm == "e")
            {
                Room4 r1 = new Room4();
                string ans = r1.Invalid();
                return ans;
            }
            else if (curr == 4 && comm == "w")
            {
                Globals.curr = 2;
                string ans = "You enter another room";
                return ans;
            }
            else if (curr == 4 && comm == "s")
            {
                Room4 r1 = new Room4();
                string ans = r1.Invalid();
                return ans;
            }


            //room5
            if (curr == 5 && comm == "look")
            {
                Room5 r1 = new Room5();
                string ans = r1.Des();
                //Console.WriteLine(ans);
                return ans;
            }
            else if (curr == 5 && comm == "n")
            {
                Room5 r1 = new Room5();
                string ans = r1.Invalid();
                return ans;
            }
            else if (curr == 5 && comm == "e")
            {
                Globals.curr = 6;
                string ans = "You get to the red door";
                return ans;
            }
            else if (curr == 5 && comm == "w")
            {
                Room5 r1 = new Room5();
                string ans = r1.Invalid();
                return ans;
            }
            else if (curr == 5 && comm == "s")
            {
                Globals.curr = 2;
                string ans = "You enter another room";
                return ans;
            }


            //room6
            if (curr == 6 && comm == "look")
            {
                Room6 r1 = new Room6();
                string ans = r1.Des();
                //Console.WriteLine(ans);
                return ans;
            }
           
            else
            {
                Room3 r1 = new Room3();
                string ans = "Invalid input";
                return ans;
            }

            
               
            

        }



    }
}




