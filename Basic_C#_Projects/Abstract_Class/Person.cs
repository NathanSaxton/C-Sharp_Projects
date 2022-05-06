using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    public abstract class Person//make this an abstract class
    {
        public string firstName { get; set; }//property 1
        public string lastName { get; set; }//property 2


        public abstract void SayName();//make this an abstract method


    }
}
