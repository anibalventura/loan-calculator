using System;

namespace BusinessLayer
{
    public class Calculator
    {
        public double CalculateLoan(int amount, int type, int months)
        {
            double finalInterest = 0;

            switch (type)
            {
                case (int)LoanTypeOptions.PERSONAL:
                    finalInterest = ((double)(int)InterestOptions.PERSONAL / 100) * amount;
                    break;
                case (int)LoanTypeOptions.VEHICLE:
                    finalInterest = ((double)(int)InterestOptions.VEHICLE / 100) * amount;
                    break;
                case (int)LoanTypeOptions.MORTAGE:
                    finalInterest = ((double)(int)InterestOptions.MORTAGE / 100) * amount;
                    break;
            }

            return (finalInterest + amount) / months;
        }
    }
}
