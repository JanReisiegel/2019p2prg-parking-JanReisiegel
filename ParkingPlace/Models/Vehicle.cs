using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ParkingPlace.Models
{
    abstract class Vehicle
    {
        protected Vehicle(string id, Color color)
        {
            Color = color;
            Id = id;
        }

        public Color Color { get; }
        public string Id { get; }

        public override string ToString()
        {
            return Color.Name + " " + Id;
        }
    }
}
