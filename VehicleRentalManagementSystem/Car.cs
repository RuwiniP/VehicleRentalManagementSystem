using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public class Car : Vehicle
    {
        // Optional properties for Car class.
        // properties are all private and cannot be modified from outside the class
        private int Seats { get; set; }
        private string EngineType { get; set; }
        private string Transmission { get; set; }
        private bool Convertible { get; set; }

        //Inherit vehicle class to get base class properties
        public Car(string model, string manufacturer, int year, decimal rentalPrice, int seats, string engineType,
            string transmission, bool convertible) : base(model, manufacturer, year, rentalPrice)
        {
            Seats = seats;
            EngineType = engineType;
            Convertible = convertible;
            Transmission = transmission;
        }

        // Overriding Vehicle class (Vehicle) method to display base class properties
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Seats: {Seats} | Engine Type: {EngineType} | Transmission: {EngineType} | Convertible: {(Convertible ? "Yes" : "No")}");
        }

    }
}
