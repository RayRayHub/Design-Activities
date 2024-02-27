using ParkingLotDesignApp.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotDesignApp.DerivedClasses.Terminals
{
    public class EntryTerminal : Terminal
    {
        public ParkingTicket GetParkingTicket(ParkingSpot parkingSpotType) { return new ParkingTicket(); }
    }
}
