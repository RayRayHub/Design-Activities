using ParkingLotDesignApp.Factories.BaseFactory;
using ParkingLotDesignApp.Interfaces;
using ParkingLotDesignApp.Strategy.PaymentProcesses;
using ParkingLotDesignApp.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotDesignApp.Factories
{
    public class ConcreteParkingLotFactory : ParkingLotFactory
    {
        public override IParkingAssignmentStrategy CreateParkingAssignmentStrategy()
        {
            return new ParkingSpotNearEnteranceStrategy();
        }

        public override IParkingFeeCalculator CreateParkingFeeCalculator()
        {
            return new ParkingFeeCalculator();
        }

        public override IPaymentProcessor CreatePaymentProcessor()
        {
            return new CreditCardPaymentProcessor();
        }
    }
}
