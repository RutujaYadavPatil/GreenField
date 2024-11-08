using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
   public class Complex
    {
        private int real;
        private int imaginary;

        //Constructor Overloding
        public Complex()
        {
            this.real = 0;
            this.imaginary = 0;
        }
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override string ToString()   //ToString method for Complex class
        {
            return this.real + " +i" + this.imaginary;
        }

        //we can overlod (+,*,-,/)operator
        public static Complex operator +(Complex a, Complex b) //Operator Overloding 
        {
            Complex temp = new Complex();
            temp.real = a.real + b.real;
            temp.imaginary=a.imaginary + b.imaginary;
            return temp;
        }
    }
}
