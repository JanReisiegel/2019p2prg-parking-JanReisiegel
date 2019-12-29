using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ParkingPlace.Models
{
    class Bus : PersonnelVehicle
    {
        public Bus(string id, Color color, int seats) : base(id, color, seats)
        {
            Seats = seats;
            Size = 5;
        }
        public override float CalculatePrice(int HoursSpent)
        {
            return 200 + base.CalculatePrice(HoursSpent);
        }
        public override string ToString()
        {
            return "Bus " + base.ToString() + " with " + Seats + " seats";
        }
    }
}
