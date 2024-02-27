using ParkingLotDesignApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotDesignApp.Strategy.PaymentProcesses
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
