using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary {
    public class Equilateral : Triangle, IShapeCalc {

        public Equilateral (double side){
            SideLength1 = side;
        }

        public double GetArea() {
            return Math.Sqrt(3) / 4 * SideLength1 * SideLength1;
        }
        public double GetPerimeter() {
            return SideLength1 * 3;
        }
    }
}
