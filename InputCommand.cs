using RobotSimulator.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    public class InputCommand
    {
        private static RobotToy robot = new RobotToy();

        public static void ParseCommandPlace(string commandPlace)
        {

            Console.WriteLine("" + commandPlace);
            string[] cmdArray = commandPlace.Split(",");
            int x = int.Parse(cmdArray[0]);
            int y = int.Parse(cmdArray[1]);
            string facing = (cmdArray[2]);

            robot.Place(x, y, facing);
            //  int x = Integer.Parse(commandPlace[2]);
            Console.WriteLine($"{cmdArray[0]},");

        }
        public static void ParseOther(string command)
        {


            switch (command)
            {
                case "MOVE":

                    robot.Move();
                    break;

                case "REPORT":
                    robot.Report();
                    break;
                case "LEFT":
                    robot.Left();
                    break;
                case "RIGHT":
                    robot.Right();

                    break;
            }
        }
    }
}
