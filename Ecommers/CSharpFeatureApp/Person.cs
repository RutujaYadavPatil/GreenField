using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
    public class Person
    {
        private string Fname;
        private string Lname;
        private int age;

        public Person()
        {
            this.Fname = "Rutuja";
            this.Lname = "Patil";
            this.age = 22;
        }
        public Person(string Fname, string Lname,int age)
        {
            this.Fname = Fname;     
            this.Lname = Lname;
            this.age = age;
        }

        public override string ToString() 
        {
            return this.Fname +" "+this.Lname+" "+this.age;
        }


    }
}
