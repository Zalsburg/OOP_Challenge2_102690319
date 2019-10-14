using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary {
    public class Rectangle : Quadrilateral {

        public Rectangle (double side1, double side2) {
            SideLength1 = side1;
            SideLength2 = side2;
        }

        public override double GetArea() {
            return base.GetArea();
        }

        public override double GetPerimeter() {
            return SideLength1 * 2 + SideLength2 * 2;
        }
    }
}
