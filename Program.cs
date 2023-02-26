using OopsConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
   
    class Program
    {
       
        static void Main(string[] args)
            {
            IPolygon r1 = new Rectangle();
            r1.calculateArea();

            IPolygon r2 = new Square();
            r2.calculateArea();


        }
    }
    
}
