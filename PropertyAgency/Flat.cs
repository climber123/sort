using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAgency
{
    public class Flat
    {
        public string Area { get; set; }
        public int Floor { get; set; }
        public int Rooms { get; set; }
        public int Square { get; set; }

        public int Cost { get; set; }

        public int Count { get; set; }

        public Flat(string area, int floor, int rooms, int square, int cost, int count)
        {
            Area = area;
            Floor = floor;
            Rooms = rooms;
            Square = square;
            Cost = cost;
            Count = 0;
        }


    }
}
