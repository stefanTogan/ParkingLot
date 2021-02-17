using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    class ParkingLotException : Exception
    {
        private string message;
        public ParkingLotException(string msg)
        {
            this.message = msg;
        }

        public string getMessage()
        {
            return this.message;
        }
    }
    class ParkingLot
    {
        private ParkingSpot[] spots = null;
        private int noAvailableSpots;
        private static int MAX_CAPACITY = 10;
        private int moneyGenerated; 
       
        public ParkingLot()
        {
            this.spots = new ParkingSpot[ParkingLot.MAX_CAPACITY];
            this.noAvailableSpots = ParkingLot.MAX_CAPACITY;
            this.moneyGenerated = 0;
        }

        public int getNoAvailableSpots() { return noAvailableSpots; }
        public int getNoOccupiedSpots() { return ParkingLot.MAX_CAPACITY - noAvailableSpots; }
        public void takeVechicleIn(Car car1)
        {
            if (car1.Parked == true)
            {
                throw new ParkingLotException("This car is already parked");
            }
            else
            {
                if (this.getNoAvailableSpots() > 0)
                {
                    int i = 0;
                    while(!spots[i].Available) { i++; }
                    car1.SpotIndex = i;
                    car1.Parked = true;
                    car1.adjutEnterTime();
                    this.noAvailableSpots--;
                    spots[i].Available = false; 
                }
                else
                {
                    throw new ParkingLotException("There are no available spots");
                }
            }

        }
        public void takeVechicleOut(Car car1)
        {
            if (car1.Parked == false)
            {
                throw new ParkingLotException("This car not parked");
            }
            else
            {
                spots[car1.SpotIndex].Available = true;
                this.noAvailableSpots++;
                car1.Parked = false;
                car1.adjustLeaveTime();
                //int numberOfHours = car1.computeParkingTime();
                //var sumar = generateSumar(car1.GetEnterTime(), car1.GetLeaveTime(), numberOfHours)
            }

        }

        internal void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
