using ParkingLotDesignApp.BaseClasses;
using ParkingLotDesignApp.DerivedClasses.ParkingSpots;
using ParkingLotDesignApp.DerivedClasses.Terminals;
using ParkingLotDesignApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotDesignApp
{
    public class ParkingSpotNearEnteranceStrategy : IParkingAssignmentStrategy
    {
        private readonly Dictionary<Guid, PriorityQueue<ParkingSpot, int>> entranceSpotsMap;
        private readonly Dictionary<Guid, HashSet<ParkingSpot>> reservedSpotsMap;

        public ParkingSpotNearEnteranceStrategy()
        {
            entranceSpotsMap = new Dictionary<Guid, PriorityQueue<ParkingSpot, int>>();
            reservedSpotsMap = new Dictionary<Guid, HashSet<ParkingSpot>>();
        }

        public ParkingSpot GetParkingSpot(Terminal terminal)
        {
            // One min-heap(priority-queue) per enterance.
            // two sets of parking spots. 1 Avaialbe. 1 Reserved.
            // Map of min heaps where the main enterance is stored at that enterance id
            // Mark the parking spot as reserved
            // Move it from available to reserved.
            // Remove the parking sport from all other min heaps as well by it's ID.
            // Klog(n) complexity as k will be the number of min-heaps and n is the amount of parking spots in that min heap we are looking in
            if (!(terminal is EntryTerminal entryTerminal))
            {
                throw new ArgumentException("Invalid terminal type. Must be EntryTerminal.");
            }

            // Retrieve or create priority queue for this entrance
            if (!entranceSpotsMap.ContainsKey(entryTerminal.Id))
            {
                entranceSpotsMap[entryTerminal.Id] = new PriorityQueue<ParkingSpot, int>();
                reservedSpotsMap[entryTerminal.Id] = new HashSet<ParkingSpot>();
                // Simulate some parking spots (for demonstration purpose)
                for (int i = 0; i < 100; i++)
                {
                    entranceSpotsMap[entryTerminal.Id].Enqueue(new CompactParkingSpot(), i+1);
                }
            }

            // Get the nearest available spot from the priority queue
            while (entranceSpotsMap[entryTerminal.Id].Count > 0)
            {
                var spot = entranceSpotsMap[entryTerminal.Id].Dequeue();
                if (!reservedSpotsMap[entryTerminal.Id].Contains(spot))
                {
                    reservedSpotsMap[entryTerminal.Id].Add(spot);
                    return spot;
                }
            }

            throw new Exception("No available parking spot near the entrance.");
        }

        public void ReleaseParkingSpot(ParkingSpot parkingSpotType)
        {
            throw new NotImplementedException();
        }
    }
}
