using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            var carOne = new Car();
            carOne.Make = "Subaru";
            carOne.Model = "WRX";
            carOne.Year = 2020;
            carOne.WheelCount = 4;
            carOne.Headquarters = "Subaru Headquarters";
            carOne.Logo = "Subaru Logo";
            carOne.HasTruck = true;
            carOne.TrunkSpece = 10;
            
            var truckOne = new Truck();
            truckOne.Make = "Mercedes Benz";
            truckOne.Model = "G550";
            truckOne.Year = 2020;
            truckOne.WheelCount = 4;
            truckOne.Headquarters = "";
            truckOne.Logo = "Mercedes Benz Logo";
            truckOne.TruckBedSpace = 20;
            truckOne.HasTruckBed = true;
            
            var suvOne = new SUV();
            suvOne.Make = "Lamborghini";
            suvOne.Model = "Urus";
            suvOne.Year = 2024;
            suvOne.WheelCount = 4;
            suvOne.Headquarters = "Lamborghini Headquarters";
            suvOne.Logo = "Lamborghini Logo";
            suvOne.Row = 3;
            suvOne.CargoSpace = 30;

            var parkingLot = new List<IVehicle>() { carOne, truckOne, suvOne };

            foreach (var rideI in parkingLot)
                
            {
                Console.WriteLine($"This is a {rideI.Make} {rideI.Model}, made in the year {rideI.Year}.\n");
                
            }





            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
