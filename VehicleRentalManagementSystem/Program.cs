using System;
using VehicleRentalManagementSystem;

public class Program
{
    private static void Main(string[] args)
    {

        // Initialize test data objects
        Car car1 = new Car("Camry", "Toyota", 2022, 30.00m, 4, "V6", "Automatic", false);
        Motorcycle motorcycle1 = new Motorcycle("S1000R", "BMW", 2021, 60.00m, 1000, "Petrol", false);
        Truck truck1 = new Truck("Toyota Tacoma", "Toyota", 2020, 70.00m, 2, "Pickup", false);
        Car car2 = new Car("Land cruiser", "Toyota", 2022, 100.00m, 7, "V8", "Automatic", false);
        Motorcycle motorcycle2 = new Motorcycle("Honda CBR600RR", "Honda", 2021, 35.00m, 600, "Gasoline", true);

        // Creating fleet by assigning capacity of 4
        Console.WriteLine("Initializing Fleet with Capacity of 4");
        RentalAgency fleet = new RentalAgency(4);

        // Adding Vehicles to the fleet
        Console.WriteLine("Adding Vehicles to Fleet \n");
        fleet.AddVehicle(car1);
        fleet.AddVehicle(car2);
        fleet.AddVehicle(motorcycle1);
        fleet.AddVehicle(truck1);
        Console.WriteLine("\n");


        // Display rental agency details after adding 4 vehicles(fleet is full)
        Console.WriteLine("Displaying rental agency details");
        fleet.PrintRentalDetails();
        Console.WriteLine("\n");

        // Trying to add another vehicle when fleet is full
        Console.WriteLine("Trying to add another vehicle");
        fleet.AddVehicle(motorcycle2);
        Console.WriteLine("\n");

        //Renting a car using display id
        Console.WriteLine("Renting a vehicle with id 2");
        fleet.RentVehicle(2, 5);
        Console.WriteLine("\n");

        //Renting a car with invalid id
        Console.WriteLine("Renting a vehicle with id 6");
        fleet.RentVehicle(6, 5);
        Console.WriteLine("\n");

        //Displaying details after renting a car with id 6
        Console.WriteLine("Displaying rental agency details");
        fleet.PrintRentalDetails();
        Console.WriteLine("\n");
    }

}