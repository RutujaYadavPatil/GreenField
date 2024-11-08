using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegation;
using Taxation;
using Penalty;
namespace CSharpFeatureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            //Object Creation
            Account acct=new Account(15000);
            //EVENT Registration
            acct.UnderBalance += PenaltyHandler.ServiceDisconnectionPenaltyCharges;
            acct.UnderBalance += PenaltyHandler.NotificationPenaltyCharges;
            //object Invocation
            acct.WithDraw(8000);


            acct.OverBalance += TaxHandler.PayProfessionalTax;
            acct.OverBalance += TaxHandler.PayGST;

            acct.Deposit(500000);

            Console.ReadLine();
        }
    }
}


/*
 
 MathEngine engine = new MathEngine();

            Console.WriteLine(MathEngine.PI);
            Console.WriteLine(engine.add(10, 20));
            Console.WriteLine(engine.add(20, 30,10));

            MathEngine.ViewNames("Rutuja", "abdcd", "hjgjff");
            MathEngine.ViewNames("Rutuja", "abd", "hjgjff" ,"yfyjfaj");
            MathEngine.ViewNames("Rutuja", "abdcd");

            MathEngine.ShowDetails(90);
            MathEngine.ShowDetails("Rutuja");
            
            MathEngine.ShowDetails(98.45);
            Person person = new Person();
            MathEngine.ShowDetails(person);

            Complex c1= new Complex(40,50);
            Complex c2= new Complex(40,50);
            Complex c3 = c1 + c2;
            Console.WriteLine(c3);


            Employee emp = new Employee { Id = 1, Name = "Rutuja", BasicSalary = 5000, DA = 500, HRA = 20000 };//Object Creation using Property Initializer
            double packageEmp = emp.ComputePay();
            Console.WriteLine(packageEmp);

            emp = new Manager { Id = 2, Name = "XYZ", BasicSalary = 5000, DA = 500, HRA = 20000, Incentive = 45000 };
            double packageMgr = emp.ComputePay();
            Console.WriteLine(packageMgr);
 * */
/* //Compile Time ,Early Binding ,Static 
           /*   Handler.PayProfessionalTax();
              Handler.PayIncomeTax();
              Handler.PayGST();
           Operation opn1 = new Operation(TaxHandler.PayIncomeTax);//Register method with  Delegate instance
           Operation opn2 = new Operation(TaxHandler.PayServiceTax);//Register method with  Delegate instance
           Operation opn3 = new Operation(TaxHandler.PayGST);//Register method with  Delegate instance
         //  opn1.Invoke(30);
          // opn1.Invoke(40);

           Operation masterOperation = null;
           masterOperation += opn1;
           masterOperation += opn2;
           masterOperation += opn3;


           masterOperation.Invoke(25);
           masterOperation -= opn3;
           Console.WriteLine("Afetr Detachment");
           masterOperation.Invoke(25);*/
