using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public class Motorcycle : Vehicle
    {

        // Optional properties for Motorcycle class.
        // properties are all private and cannot be modified from outside the class
        private int EngineCapacity { get; set; }
        private string FuelType { get; set; }
        private bool HasFairing { get; set; }

        //Inherit vehicle class to get base class properties
        public Motorcycle(string model, string manufacturer, int year,
            decimal rentalPrice, int engineCapacity, string fuelType, bool hasFairing) : base(model, manufacturer, year,
            rentalPrice)
        {
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
            HasFairing = hasFairing;
        }

        // Overriding Vehicle class (Vehicle) method to display base class properties
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Engine Capacity: {EngineCapacity} | Fuel Type: {FuelType} | Has Fairing: {(HasFairing ? "Yes" : "No")}");
        }
    }
}
