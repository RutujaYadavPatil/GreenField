using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }

        public double HRA { get; set; }
        public double DA { get; set; }

        public virtual double ComputePay()
        {
            return BasicSalary + HRA + (25 * DA);
        }
    }
    //Sealed Keyword : We can use the Sealed Keyword before any class for  which dont want to create child class
    public class Manager : Employee
    {
        public double Incentive { get; set; }
        public override double ComputePay()
        {
            return Incentive + base.ComputePay();
        }
    }
}
