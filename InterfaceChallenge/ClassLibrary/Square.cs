using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary {
    public class Square : Quadrilateral{

        public Square (double side) {
            SideLength1 = side;
        }

        public override double GetArea() {
            return SideLength1 * SideLength1;
        }

        public override double GetPerimeter() {
            return SideLength1 * 4;
        }
    }
}
