using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    class Car
    {

        private readonly string licensePlate;
        private bool parked;
        private int spotIndex;
        DateTime enterDate;
        DateTime leaveDate;

        public Car() { this.parked= false; this.spotIndex = -1; }

        public Car(string lp) { this.licensePlate = lp; this.spotIndex = -1; }

        public int SpotIndex
        {
            get { return spotIndex; }
            set { spotIndex = value; }
        }
        public bool Parked
        {
            get { return parked; }
            set { parked = value;}
        }
        public string getLicensePlate() { return licensePlate; }

        public void adjutEnterTime() { enterDate = DateTime.Now; }

        public void adjustLeaveTime() { leaveDate = DateTime.Now; }

        public string GetEnterTime() { return enterDate.ToString("t"); }
        public string GetLeaveTime() { return leaveDate.ToString("t"); }



    }
}
