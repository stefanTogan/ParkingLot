using System;
using System.Collections.Generic;

namespace ParkingLot
{
    public enum VechicleSize {Motorcycle, Compact, Large }
    class Program
    {
        
        static void Main(string[] args)
        {
            var car1 = new Car();
            var car2 = new Car();

            car1.adjutEnterTime();
            car2.adjustLeaveTime();

            Console.WriteLine(car1.GetEnterTime());
            Console.WriteLine(car2.GetLeaveTime());

            //try
            //{
            //    var sumar1 = car1.clearSpots();
            //    sumar1.DisplayInfo();
            //}
            //catch (ParkingLotException err)
            //{
            //    Console.WriteLine(err.message);
            //}


        }
    }
}
