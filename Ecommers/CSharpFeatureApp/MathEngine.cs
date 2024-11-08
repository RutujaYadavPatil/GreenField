using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
    internal class MathEngine
    {
        public static readonly double PI;//static and read only variable is define first and then it initialize in the constructor
                                         //,and to  initialize the static read only variable it required the static Constructor
                                         //and once we initialize it in constructor then we can not change it's value.
        public const int num = 98;
           /* for const variable it is needed to initialize the variable at the time of declaration and we can not change its value further*/

      static MathEngine()
        {
            PI = 3.14; 
        }
        //static Variable is called using the className.VariableName; dont need to create Object of class for calling variable and method
        //Method Overloading
        public int add(int num1,int num2) 
        { 
            return num1 + num2;
        }
        public int add(int num1,int num2,int num3) 
        {
            return num1 + num2+num3;
        }


        public static void ViewNames(params string[] names) //params keyword allows you to call function with N no of Parameter
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        public static void ShowDetails(object o) //it accepting the all dataTypes because Object is Super Class of Every data Type
        {
            Console.WriteLine(o); //it Automatically calls tostring() method of derived class
          
        }
    }
}
