using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    internal class Triangle
    {
        // Fields for calculating triangle area.
        public float SideA;
        public float SideB;

        public Triangle(float _SideA, float _SideB)
        {
            SideA = _SideA;
            SideB = _SideB;
        }

        // Calculating area and printing result.
        public void GetTriangleArea()
        {
            float sum = 0f;
            sum = SideA * SideB / 2;
            Console.WriteLine("The Triangles area is {0} cm2", sum);
            Console.WriteLine("-----------------------------------");
        }      
    }
}
