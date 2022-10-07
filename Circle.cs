using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsJT
{
    internal class Circle
    {
        public double radius { get; set; }

        //calculate C -> does the equation
        //calculate formatted C -> creates the string that allows it to be more easily displayed. (see LINQ lab?)
         //regular is raw equations
         //formated is to call the methods for the results, and display them?
         //( can also just output rounded numbers from one method, may not need formated)

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return Math.Round(circumference, 2);   //round to 2 decimal places
        }

        public double CalculateArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return Math.Round(area, 2);   //round to 2 decimal places
        }

    }

    
}
