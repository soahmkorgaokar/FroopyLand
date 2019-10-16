using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureData
{
    class Rooms
    {
        public string Invalid()
        {
            string inv = "No exits in this direction";
            return inv;
        }
        public string Description(int roomno)
        {
            String line;
            try
            {
                //Pass the file name to the StreamReader constructor
                StreamReader sr = new StreamReader("rooms.txt");



                line = sr.ReadLine();
                while(line!=null)
                {
                    if (line == roomno.ToString())
                    {
                        line = sr.ReadLine();
                        while (line != null && line != "--")
                        {
                            //write the lie to console window
                            Console.WriteLine(line);
                            //Read the next line
                            line = sr.ReadLine();
                        }
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }

                }

                //Continue to read until you reach end of file
              

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("");
            }

            string inv = "";
            return inv;
        }
    }
}
