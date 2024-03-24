using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public class RentalAgency
    {
        // Properties
        private Vehicle[] Fleet { get; set; }
        private decimal TotalRevenue { get; set; }

        // Initialize the fleet with given size.
        public RentalAgency(int fleetCapacity)
        {
            Fleet = new Vehicle[fleetCapacity];
        }

        // Adding vehicles to the fleet and display error when fleet is full.
        public void AddVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] == null)
                {
                    Fleet[i] = vehicle;
                    Console.WriteLine("Vehicle has been added.");
                    break;
                }
                else if (i == Fleet.Length - 1)
                {
                    Console.WriteLine("Error: Fleet is full! Cannot add more vehicles.");
                    break;
                }
            }

        }

        // Remove vehicle from the fleet by given id.
        private void RemoveVehicle(int id)
        {
            Fleet[id - 1] = null;
        }

        /* Calculate the rental charge for given vehicle by multiplying it's rental charge from rental days.
         an then remove it from the fleet.
         */
        public void RentVehicle(int id, int days)
        {
            if (id - 1 >= 0 && id - 1 < Fleet.Length && Fleet[id - 1] != null)
            {
                TotalRevenue += Fleet[id - 1].RentalPrice * days;
                RemoveVehicle(id);
                Console.WriteLine($"Vehicle id {id} has been rented out for {days} days.");
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }

        }


        // Optional: Print Rental Revenue and vehicle details
        public void PrintRentalDetails()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 150)));

            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] != null)
                {
                    Console.Write($"ID: {i + 1} | ");
                    Fleet[i].DisplayDetails();
                }
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 150)));
            Console.WriteLine($"Total Revenue: {TotalRevenue}");

        }
    }
}
