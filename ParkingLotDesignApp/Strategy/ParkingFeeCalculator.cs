using ParkingLotDesignApp.BaseClasses;
using ParkingLotDesignApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotDesignApp.Strategy
{
    public class ParkingFeeCalculator : IParkingFeeCalculator
    {
        public decimal CalculateParkingFee(DateTime entryDateTime, ParkingSpot parkingSpotType)
        {
            throw new NotImplementedException();
        }
    }
}
