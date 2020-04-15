using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasFourWheels { get; set; }
        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"I am driving my vehical, it is {Make} {Model}");
        }
    }
}
