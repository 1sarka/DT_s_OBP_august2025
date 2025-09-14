using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prezi_beispiel
{
    internal class Haus
    {
        //fields
        private int roomsNumber = 3;
        private Color color;

        //property
        public int RoomsNumber{ get
            {
                return roomsNumber;
            }
            set
            {
                roomsNumber = value;
            }
        }
        
        
        //method
        public void BuildHouse(int year, string wallcallor, int roomsNumber)
        {
            Console.WriteLine($"this house is bild in year {year} and the color of walls is {wallcallor}, number of the rooms is {roomsNumber}");
        }
        
    }
}
