using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegation;
namespace CSharpFeatureApp
{
    public class Account
    {

        public event Operation UnderBalance;
        public event Operation OverBalance;
        public double Balance {  get; set; }

        public Account(double initialAmount)
        {
            Balance = initialAmount;
        }
        public void WithDraw(double amount)
        {
            double result=Balance-amount;
            if(result<=10000)
            {
                //raise an event :UnderBalance
                UnderBalance(5);
            }
            Balance=result;
        }
        public void Deposit(double amount) 
        {
            Balance += amount;
            if(Balance>=250000)
            {
                OverBalance(10);
                //raise an event :OverBalance
            }
        }

    }
}
