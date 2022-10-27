using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    internal class Circle
    {
        // fields//properties needed to calculate the area of a circle

        public int Radius;
        public float Pi = 3.141f;

        public Circle(int _number)
        {
            Radius = _number;
        }

        // Methods for calculating and printing the wanted results.
        public void GetAreaOfCircle()
        {
            float sum = 0;
            sum = Radius * Radius * Pi;
            Console.WriteLine("arean på cirkeln är {0} cm2", sum);

        }
        public void GetCircomference()
        {
            float sum = 0;
            sum = Radius * 2 * Pi;
            Console.WriteLine("Omkretsen på cirkeln är {0} cm", sum);
        }
        public void GetSphere()
        {
            float sum = 0;
            sum = (float)(4.0 / 3 * Pi * Radius * Radius * Radius);
            Console.WriteLine("Som sfär har den {0} i area.", sum);
            Console.WriteLine("-----------------------------------");
        }
    }
}
