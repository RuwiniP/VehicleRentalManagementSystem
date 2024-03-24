using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public class Truck: Vehicle
    {

        // Optional properties for Truck class.
        // properties are all private and cannot be modified from outside the class
        private int Capacity { get; set; }
        private string TruckType { get; set; }
        private bool FourWheelDrive { get; set; }

        //Inherit vehicle class to get base class properties
        public Truck(string model, string manufacturer, int year,
            decimal rentalPrice, int capacity, string truckType,
            bool fourWheelDrive) : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        // Overriding Vehicle class (Vehicle) method to display base class properties
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {Capacity} | Truck Type: {TruckType} | Four Wheel Drive: {(FourWheelDrive ? "Yes" : "No")}");
        }
    }
}
