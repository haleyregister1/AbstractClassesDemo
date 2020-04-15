using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasTwoWheels { get; set; }
        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Vroom, Vroom");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("this is my motorcycle!");
            base.DriveVirtual();
        }
    }
}
