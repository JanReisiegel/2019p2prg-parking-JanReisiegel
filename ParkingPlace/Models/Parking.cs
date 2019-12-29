using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingPlace.Models
{
    class Parking
    {
        public List<IParkable> ParkingSpaces { get; }
        public int Total { get; }
        public int Occupied { get; protected set; }
        public int Free { get { return (Total - Occupied); } }
        public float Revenue { get; private set; }
        public Parking(int total)
        {
            ParkingSpaces = new List<IParkable>();
            Total = total;
            Occupied = 0;
        }
        public bool Add(IParkable client)
        {
            if (client.Size <= Free)
            {
                ParkingSpaces.Add(client);
                Occupied = Occupied + client.Size;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool TryAdd(object client)
        {
            if (client is IParkable)
            {
                return this.Add(client as IParkable);
            }
            else
            {
                return false;
            }
        }
        public bool Remove(IParkable client, int HoursSpent, out float price)
        {
            if (ParkingSpaces.Remove(client) && HoursSpent > 0)
            {
                price = client.CalculatePrice(HoursSpent);
                Revenue = Revenue + price;
                Occupied = Occupied - client.Size;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
    }
}
