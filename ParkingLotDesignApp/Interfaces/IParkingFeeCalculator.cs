using ParkingLotDesignApp.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotDesignApp.Interfaces
{
    public interface IParkingFeeCalculator
    {
        decimal CalculateParkingFee(DateTime entryDateTime, ParkingSpot parkingSpotType);
    }
}
