using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotDesignApp.BaseClasses
{
    public class ParkingTicket
    {
        //Properties
        public Guid Id { get; set; }
        public int ParkingSpotId { get; set; }
        public ParkingSpot ParkingSpotType { get; set; }
        public DateTime IssuedTime { get; set; }
        public string LicensePlate { get; set; }
    }
}
