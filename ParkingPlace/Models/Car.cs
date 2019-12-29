using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ParkingPlace.Models
{
    class Car : PersonnelVehicle
    {
        public Car(string id, Color color, int seats) : base(id, color, seats)
        {
            Seats = seats;
            Size = 1;
        }
        public override double CalculatePrice(int HousrsSpent)
        {
            return 15 * HousrsSpent;
        }
        public override string ToString()
        {
            return "Car " + Color + " " + Id;
        }
    }
}
