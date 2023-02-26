using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    //..............access single interface into multiple class...........................
    interface IPolygon
    {

        void calculateArea();

    }

    class Rectangle : IPolygon
    {


        public void calculateArea()
        {

            int l = 10;
            int b = 20;
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }

    class Square : IPolygon
    {


        public void calculateArea()
        {

            int l = 10;
            int area = l * l;
            Console.WriteLine("Area of Square: " + area);
        }
    }
}
