using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingPlace.Models
{
    class Horse : IParkable
    {
        public Horse(string id)
        {
            Id = id;
            Size = 1;
        }

        public string Id { get; }
        public int Size { get; }
        public float CalculatePrice(int HoursSpent)
        {
            return HoursSpent;
        }
        public override string ToString()
        {
            return "Horse " + Id;
        }
    }
}
