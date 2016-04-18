using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    class Program
    {
        static void Main(string[] args)
        {
            test t = new test();
            t.print();
            Console.WriteLine("test");

            const double maturity = 1.0;
            const double strike = 1.0;
            const double volatility = 0.2;
            const double interestRate = 0.1;
            const double spot = 100;



            BlackScholes model = new BlackScholes();
            double price = model.calculatePrice(maturity, volatility, strike, spot, interestRate);
            Console.WriteLine(price);
        }
    }
}
