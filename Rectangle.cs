using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    interface IPolygon
    {
        // use multiple interface to access in single class //  multiple inheritancs
        void calculateArea(int l, int b);

    }
    interface IColor
    {

        void calculateArea(int l, int b);
            void getColor();


    }


    internal class Rectangle : IPolygon, IColor
    {
        void IColor.calculateArea(int l, int b)
        {
          
            int area = l * b ;
            Console.WriteLine("Area of Rectangle in Icolor interface : " + area);
        }
         void IPolygon.calculateArea(int l, int b)
        {
           
            int area = l * b ;
            Console.WriteLine("Area of Rectangle in Ipolygon interface : " + area);
        }
       
        public void getColor()
        {

            Console.WriteLine("Red Rectangle");

        }
    }
}
