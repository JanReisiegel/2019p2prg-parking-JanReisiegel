using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ParkingPlace.Models
{
    class Tank : Vehicle
    {
        public int Size { get; }
        public Tank(string id, Color color) : base(id, color)
        {
            Size = 2;
        }
        public virtual float CalculatePrice(int HoursSpent)
        {
            return 10000;
        }
        public override string ToString()
        {
            return "Tank " + base.ToString();
        }
    }
}
