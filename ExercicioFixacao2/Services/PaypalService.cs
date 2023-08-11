using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao2.Services
{
    internal class PaypalService : OnlinePaymentService
    {
        public const double FeePercentage = 0.02;
        public const double MonthlyInterest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}
