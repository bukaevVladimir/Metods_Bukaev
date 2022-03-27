using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstList
{
    public class Car
    {
        public string Model { get; private set; }

        public Car(string model) 
        {
            Model = model;
        }
        public void Drive()
        {
            Console.WriteLine("I'm Drive");
        }

    }
}
