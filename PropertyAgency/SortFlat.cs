using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAgency
{
    public class SortFlat
    {
        //public Flat[] flat;
        public string area;
        public int floor;
        public int rooms;
        public int square_from;
        public int square_to;
        public int cost;
        public int n;

        /* передавать квартиры как параметр, переписать сортировку*/
        public SortFlat(/*Flat[] flat*/ string area, int floor, int rooms, int square_from, int square_to, int cost, int n)
        {
            //this.flat = flat;
            this.area = area;
            this.floor = floor;
            this.rooms = rooms;
            this.square_from = square_from;
            this.square_to = square_to;
            this.cost = cost;

            this.n = n;
        }

        public void ChoosePropertyFlat(Flat[] flat)
        {
            for (int i = 0; i < n; i++)
            {
                
                if (area == flat[i].Area)
                    flat[i].Count++;
                if (floor == flat[i].Floor)
                    flat[i].Count++;
                if (rooms == flat[i].Rooms)
                    flat[i].Count++;
                if (square_from <= flat[i].Square && square_to >= flat[i].Square)
                    flat[i].Count++;
                if (cost >= flat[i].Cost)
                    flat[i].Count++;
            }
        }
        public void Sort(Flat[] f)
        {
            {
                Flat x = null;
                int i, j;
                for (i = 0; i < f.Length; i++)
                {
                    x = f[i];
                    for (j = i - 1; j >= 0 && f[j].Count > x.Count; j--)
                        f[j + 1] = f[j];

                    f[j + 1] = x;
                }
            }
        }

    }
}
