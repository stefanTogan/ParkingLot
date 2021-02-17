using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    class ParkingSpot : Spot
    {
        private readonly int spotNumber;
        public bool available;
        public ParkingSpot(){ spotNumber = fakeID++; available = true; }
        public int GetSpotNumber(){ return spotNumber; }

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }


    }
}
