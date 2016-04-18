using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    public class BlackScholes
    {

        public double calculatePrice(double maturity, double volatility,
            double strike, double spot, double interestRate)
            {
                normalDistribution norm = new normalDistribution();
                double d1 = (Math.Log(spot / strike) + (interestRate + volatility * volatility * 0.5) * maturity) / (volatility * Math.Sqrt(maturity));
                double d2 = (Math.Log(spot / strike) + (interestRate - volatility * volatility * 0.5) * maturity) / (volatility * Math.Sqrt(maturity));
                double price = spot * norm.cdf(d1) - strike * Math.Exp(-interestRate * maturity) * norm.cdf(d2);
                return price;
            }
    }
}
