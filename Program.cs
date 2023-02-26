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
            //using refernce name of interface
             IPolygon r1 = new Rectangle();
             IColor r2 = new Rectangle();
             r1.calculateArea(10, 10);
              r2.calculateArea(20, 10);



        }
    }
    
}
