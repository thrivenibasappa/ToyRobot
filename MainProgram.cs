
using RobotSimulator.Robot;

namespace RobotSimulator
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {

            //  const string userInfo = "";
            //"
            Console.WriteLine("1: Use the command as below:\n");
            Console.WriteLine(" PLACE X,Y,F (Where X and Y are integers and F \r\n      must be either N, S, E or W)\n");
            Console.WriteLine(" 2:commands to use are\n");
            Console.WriteLine("\t REPORT – Shows the current status of the toy. \n");
            Console.WriteLine("\t LEFT   – turns  90 degrees left from the current postion.\n");
            Console.WriteLine("\t RIGHT  – turns  90 degrees right from the current postion.\n");
            Console.WriteLine("\t MOVE   – Moves the toy 1 unit in the direction which facing it is.\n");
            Console.WriteLine("\t EXIT   – Closes the applicaiton.\n");


            var stopApplication = false;
            string[] output;
            Dictionary<string, string> cmdstr = new Dictionary<string, string>();
            do
            {
                var command = Console.ReadLine();
                if (command == null) continue;

                if (command.Split(' ').Length > 1)
                {
                    try
                    {
                        output = command.Split(' ');
                        if ((output.Length == 0))
                            Console.WriteLine("Please enter the valid input");
                        if (output[0].ToUpper().Equals("PLACE"))
                        {
                            if (output.Length == 2)
                            {
                                cmdstr.Add("PLACE", output[1]);
                                //InputCommand.ParseCommandPlace(command);
                            }
                            else
                            {
                                Console.WriteLine("The format is Place X,Y,Facing");
                            }

                        }

                        /* */
                    }
                    catch (ArgumentException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
                else if (command.ToUpper().Equals("MOVE"))
                {
                    //InputCommand.ParseOther(output[0].ToUpper());
                    cmdstr.Add("MOVE", command.ToUpper());
                }
                else if (command.ToUpper().Equals("LEFT"))
                {
                    cmdstr.Add("LEFT", command.ToUpper());
                }
                else if (command.ToUpper().Equals("RIGHT"))
                {
                    cmdstr.Add("RIGHT", command.ToUpper());
                }
                else if (command.ToUpper().Equals("REPORT"))
                {
                    cmdstr.Add("REPORT", command.ToUpper());

                    foreach (KeyValuePair<string, string> cmd in cmdstr)
                    {
                        if (cmd.Key.Equals("PLACE"))
                        {
                            InputCommand.ParseCommandPlace(cmd.Value);
                        }
                        else
                        {
                            InputCommand.ParseOther(cmd.Value);
                        }

                    }

                    cmdstr.Clear();
                 
                }
                else
                {
                   
                    //if (command.Equals("EXIT"))
                        stopApplication = true;
                }
            } while (!stopApplication);



        }


    }


}