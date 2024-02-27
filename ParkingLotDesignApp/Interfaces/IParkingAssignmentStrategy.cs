using ParkingLotDesignApp.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotDesignApp.Interfaces
{
    public interface IParkingAssignmentStrategy
    {
        ParkingSpot GetParkingSpot(Terminal terminal);

        void ReleaseParkingSpot(ParkingSpot parkingSpotType);
    }
}
