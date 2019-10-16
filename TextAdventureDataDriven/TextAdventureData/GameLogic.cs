using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureData
{
    class GameLogic
    {
        private static GameLogic uniqueinstance = new GameLogic();
        public static GameLogic getinstanceg()
        {
            return uniqueinstance;
        }

        //MOVE decides what function to call depending upon the current room the player is in and the command they execute
        public string Move(int currentroom, string command)
        {
            Rooms room1 = new Rooms();
            Rooms room2 = new Rooms();
            Rooms room4 = new Rooms();
            Rooms room3 = new Rooms();
            Rooms room5 = new Rooms();
            Rooms room6 = new Rooms();

            //Console.WriteLine(currentroom);
                //room1
                if (currentroom == 1 && command == "look")
                {
                    string ans = room1.Description(currentroom);
                    //Console.WriteLine(ans);
                    return ans;
                }
            if (currentroom == 1 && command == "n")
            {
               
                string ans = room1.Invalid();
                return ans;
            }
            else if (currentroom == 1 && command == "e")
            {
                Globals.currentroom = 2;
                string ans = "You enter another room";
                return ans;
            }
            else if (currentroom == 1 && command == "w")
            {
               
                string ans = room1.Invalid();
                return ans;
            }
            else if (currentroom == 1 && command == "s")
            {
             
                string ans = room1.Invalid();
                return ans;
            }

            //room2
                            else if (currentroom == 2 && command == "look")
                            {
                               
                                string ans = room2.Description(currentroom);
                                //Console.WriteLine(ans);
                                return ans;
                            }
                            else if (currentroom == 2 && command == "n")
                            {
                                Globals.currentroom = 5;
                                string ans = "You enter another room";
                                return ans;
                            }
                            else if (currentroom == 2 && command == "e")
                            {
                                Globals.currentroom = 4;
                                string ans = "You enter another room";
                                return ans;
                            }
                            else if (currentroom == 2 && command == "w")
                            {
                                Globals.currentroom = 1;
                                string ans = "You enter another room";
                                return ans;
                            }
                            else if (currentroom == 2 && command == "s")
                            {
                                Globals.currentroom = 3;
                                string ans = "You enter another room";
                                return ans;
                            }

                            //room3
                            if (currentroom == 3 && command == "look")
                            {
                                Rooms r1 = new Rooms();
                                string ans = r1.Description(currentroom);
                                //Console.WriteLine(ans);
                                return ans;
                            }
                            else if (currentroom == 3 && command == "n")
                            {
                                Globals.currentroom = 2;
                                string ans = "You enter another room";
                                return ans;
                            }
                            else if (currentroom == 3 && command == "e")
                            {
                                
                                string ans = room3.Invalid();
                                return ans;
                            }
                            else if (currentroom == 3 && command == "w")
                            {
                                
                                string ans = room3.Invalid();
                                return ans;
                            }
                            else if (currentroom == 3 && command == "s")
                            {
                          
                                string ans = room3.Invalid();
                                return ans;
                            }


                            //Room4
                            if (currentroom == 4 && command == "look")
                            {
                                
                                string ans = room4.Description(currentroom);
                                //Console.WriteLine(ans);
                                return ans;
                            }
                            else if (currentroom == 4 && command == "n")
                            {
                               
                                string ans = room4.Invalid();
                                return ans;
                            }
                            else if (currentroom == 4 && command == "e")
                            {
                                
                                string ans = room4.Invalid();
                                return ans;
                            }
                            else if (currentroom == 4 && command == "w")
                            {
                                Globals.currentroom = 2;
                                string ans = "You enter another room";
                                return ans;
                            }
                            else if (currentroom == 4 && command == "s")
                            {
                                
                                string ans = room4.Invalid();
                                return ans;
                            }


                            //room5
                            if (currentroom == 5 && command == "look")
                            {
                               
                                string ans = room5.Description(currentroom);
                                //Console.WriteLine(ans);
                                return ans;
                            }
                            else if (currentroom == 5 && command == "n")
                            {
                                
                                string ans = room5.Invalid();
                                return ans;
                            }
                            else if (currentroom == 5 && command == "e")
                            {
                                Globals.currentroom = 6;
                                string ans = "You get to the red door";
                                return ans;
                            }
                            else if (currentroom == 5 && command == "w")
                            {
                                
                                string ans = room5.Invalid();
                                return ans;
                            }
                            else if (currentroom == 5 && command == "s")
                            {
                                Globals.currentroom = 2;
                                string ans = "You enter another room";
                                return ans;
                            }


                            //room6
                            if (currentroom == 6 && command == "look")
                            {
                                
                                string ans = room6.Description(currentroom);
                                //Console.WriteLine(ans);
                                return ans;
                            }

                            else
                            {
                                string ans = "Invalid input";
                                return ans;
                            }

           




                        }

            

        }
    }


