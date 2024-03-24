using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public class Vehicle
    {
        // Base class properties
        private string Model { get; set; }
        private string Manufacturer { get; set; }
        private int Year { get; set; }

        public readonly decimal RentalPrice; // This property can only be read by other classes

        // Constructor of the base classs
        protected Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }

        // Displaying base properties
        public virtual void DisplayDetails()
        {
            Console.Write($"Model: {Model} | Manufacturer: {Manufacturer} | Year: {Year} | Rental Price: {RentalPrice} | ");
        }
    }
}
