using ParkingLotDesignApp.BaseClasses;
using ParkingLotDesignApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotDesignApp
{
    // Singleton Parking Lot
    public class ParkingLot
    {
        private static ParkingLot instance;
        private List<ParkingSpot> parkingSpots;

        private ParkingLot()
        {
            parkingSpots = new List<ParkingSpot>();
        }

        public static ParkingLot Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ParkingLot();
                }
                return instance;
            }
        }

        public void AddParkingSpot(ParkingSpot parkingSpot)
        {
            parkingSpots.Add(parkingSpot);
        }

        public void RemoveParkingSpot(ParkingSpot parkingSpot)
        {
            parkingSpots.Remove(parkingSpot);
        }

        public void DisplayParkingSpots()
        {
            foreach (var spot in parkingSpots)
            {
                Console.WriteLine($"Parking Spot ID: {spot.Id}, Reserved: {spot.IsReserved}");
            }
        }
    }
}
