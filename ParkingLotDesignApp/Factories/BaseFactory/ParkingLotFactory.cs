using ParkingLotDesignApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotDesignApp.Factories.BaseFactory
{
    public abstract class ParkingLotFactory
    {
        public abstract IParkingAssignmentStrategy CreateParkingAssignmentStrategy();
        public abstract IParkingFeeCalculator CreateParkingFeeCalculator();
        public abstract IPaymentProcessor CreatePaymentProcessor();
    }
}
