using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ParkingPlace.Models
{
    abstract class PersonnelVehicle : Vehicle, IParkable
    {
        protected PersonnelVehicle(string id, Color color, int seats) : base(id, color)
        {
            Seats = seats;
        }

        public int Size { get; protected set; }
        public int Seats { get; protected set; }
        public virtual float CalculatePrice(int HousrsSpent)
        {
            return Size * HousrsSpent * Seats;
        }
    }
}
