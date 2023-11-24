using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator.Robot
{
    public class RobotToy
    {
        public int x;
        public int y;
        public string Facing;

        public RobotToy() : this(0, 0, "North")
        {

        }
        public RobotToy(int x, int y, string facing)
        {

            if (IsValidPositon(x, y))
            {
                this.x = x;
                this.y = y;
                this.Facing = facing;
            }
            else
            {
                this.x = 0;
                this.y = 0;
                this.Facing = "North";
            }

        }

        public bool IsValidPositon(int x, int y)
        {

            return ((x >= 0 && x <= 5) && (y >= 0 && y <= 5));
        }


        public void Report()
        {

            Console.WriteLine($"{x}, {y} , {Facing}");
            this.ToString();
        }


        public void Place(int x, int y, string facing)
        {


            if (IsValidPositon(x, y))
            {
                this.x = x;
                this.y = y;
                this.Facing = facing.ToUpper();
                Console.WriteLine("Input:");
                Report();

            }
            else
            {
                Console.WriteLine("It crossed the bounds");
                Environment.Exit(0);
            }


        }

        public void Move()
        {

            switch (Facing)
            {
                case "NORTH":
                    y = y + 1;
                    if (!IsValidPositon(this.x, y))
                    {
                        Console.WriteLine("It crossed the bounds");
                        break;
                    }
                    break;
                case "SOUTH":
                    y = y - 1;
                    if (!IsValidPositon(this.x, y))
                    {
                        Console.WriteLine("It crossed the bounds");
                        break;
                    }
                    break;
                case "WEST":
                    x = x - 1;
                    if (!IsValidPositon(x, this.y))
                    {
                        Console.WriteLine("It crossed the bounds");
                        break;
                    }
                    break;
                case "EAST":

                    x = x + 1;
                    if (!IsValidPositon(x, this.y))
                    {
                        Console.WriteLine("It crossed the bounds");
                        break;
                    }
                    break;
            }

        }

        public void Left()
        {
            switch (Facing)
            {
                case "NORTH":
                    Facing = "West";
                    break;
                case "SOUTH":
                    Facing = "East";
                    break;
                case "WEST":
                    Facing = "South";
                    break;
                case "EAST":
                    Facing = "North";
                    break;
            }
        }

        public void Right()
        {
            switch (Facing)
            {
                case "North":
                    Facing = "East";
                    break;
                case "South":
                    Facing = "West";
                    break;
                case "West":
                    Facing = "North";
                    break;
                case "East":
                    Facing = "South";
                    break;
            }
        }

    }
}
