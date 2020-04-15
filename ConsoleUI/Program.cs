using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments in each section! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

             List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances, 1 Car, 1 Motorcycle, and then 2 Vehicles - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car myFirstCar = new Car()
            {
                Make = "Cadillac",
                Model = "SRX",
                Year = "2014",
                HasFourWheels = true,
                HasTrunk = true
            };
            Motorcycle myFirstBike = new Motorcycle()
            {
                Make = "Harley Davidson",
                Model = "Sportster",
                Year = "2013",
                HasTwoWheels = true,
                HasSideCar = true
            };
            Vehicle myDreamCar = new Car()
            {
                Make = "Ford",
                Model = "Mustang",
                Year = "1969",
                HasFourWheels = true,
                HasTrunk = true
            };
            Vehicle myDreamBike = new Motorcycle()
            {
                Make = "Harley Davidson",
                Model = "Shovel Head",
                Year = "1984",
                HasSideCar = true,
                HasTwoWheels = true
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(myFirstCar);
            vehicles.Add(myFirstBike);
            vehicles.Add(myDreamCar);
            vehicles.Add(myDreamBike);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }

            // Call each of the drive methods for one car and one motorcycle

            myFirstCar.DriveAbstract();
            myFirstBike.DriveAbstract();

            #endregion            
            Console.ReadLine();
        }
    }
}
