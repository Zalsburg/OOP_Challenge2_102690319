using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary {
    public class RightAngle : Triangle, IShapeCalc {

        public RightAngle (double side1, double side2) {
            SideLength1 = side1;
            SideLength2 = side2;
            SetHypotenuse();
        }

        public void SetHypotenuse() {
            SideLength3 = Math.Sqrt(SideLength1 * SideLength1 + SideLength2 * SideLength2);
        }

        public double GetArea() {
            return 0.5 * SideLength1 * SideLength2;
        }
        public double GetPerimeter() {
            return SideLength1 + SideLength2 + SideLength3;
        }
    }
}
