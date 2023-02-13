﻿using System;
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

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var vehicles = new List<IVehicle>();

            var sedan = new Car()
            {
                Name = "Honda",
                CanHonk = true,
                CarColor = "Green",
                HasSteeringWheel = true,
                HasStereo = true,
                HasTrunk = true,
                NumberOfWheels = 4,
                Location = "Florida"
            };

            vehicles.Add(sedan);


            var pickup = new Truck()
            {
                Name = "GMC",
                CanHonk = true,
                CarColor = "Black",
                HasBigWheels = true,
                HasStereo = true,
                HasTruckBed = true,
                NumberOfWheels = 8,
                Location = "South Carolina"
            };
            vehicles.Add(pickup);

            var suv1 = new SUV()
            {
                Name = "Jeep",
                CanHonk = true,
                CarColor = "Dark Blue",
                HasFourWheelDrive = true,
                HasStereo = true,
                IsFourDoor = true,
                NumberOfWheels = 4,
                Location = "California"
            };

            vehicles.Add(suv1);


            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"The vehicle name is {vehicle.Name}. This {vehicle.Name} can honk and it is the color {vehicle.CarColor}. It has {vehicle.NumberOfWheels} wheels and is currently located in {vehicle.Location}");
            }

        }
    }
}
