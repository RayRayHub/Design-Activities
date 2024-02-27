using System;
using System.Collections.Generic;

public class ParkingLot
{
    List<ParkingSpot> ParkingSpots;

    public ParkingLot(int NumberOfSpaces)
    {
        ParkingSpots = new List<ParkingSpot>();

        for (int i = 0; i < NumberOfSpaces; i++)
        {
            ParkingSpots.Add(new ParkingSpot());
        }
    }
}