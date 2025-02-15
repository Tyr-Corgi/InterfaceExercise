﻿using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - Done

            //Create 3 classes called Car , Truck , & SUV - Done

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common. - done
                 * Example: All vehicles have a number of wheels... for now.. - done
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each and every company - done
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

            var sedan1 = new Car() { Year = 2018, Make = "Honda", Model = "Accord", CorpName = "BrandX", GasMilage = 40.4, Seats = 6, HowManyDoors = 4, Tires = 4 };

            var pickup1 = new Truck() { Year = 2020, Make = "Ford", Model = "F150", Bankrupt = false, GasMilage = 15, HowManyDoors = 2, Seats = 5, Tires = 4 };

            var suv1 = new SUV() { Year = 2022, CorpName = "Coolest", Make = "Lexus", Model = "RX450", Bankrupt = false, FOurWheelDrive = true, GasMilage = 26, Seats = 5, HowManyDoors = 5, Tires = 4 };

            vehicles.Add(sedan1 );
            vehicles.Add(pickup1 );
            vehicles.Add(suv1 );

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Year: {veh.Year}, Make: {veh.Make}, Model: {veh.Model}");
            }

        }
    }
}
