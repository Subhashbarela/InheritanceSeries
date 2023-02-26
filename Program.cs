using OopsConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    interface IPolygon
    {
         void calculateArea(int l, int b);

    }
    class Program: IPolygon
    {
        public void calculateArea(int l, int b)
        {
            
            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
        static void Main(string[] args)
            {
          Program Obj= new Program();
            Obj.calculateArea(1, 2);
            
           }
        }
    
}
