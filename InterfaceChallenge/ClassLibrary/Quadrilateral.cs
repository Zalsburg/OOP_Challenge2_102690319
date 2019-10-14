using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary {
    public abstract class Quadrilateral : Shape, IShapeCalc {
        public double SideLength1;
        public double SideLength2;
        public double SideLength3;
        public double SideLength4;

        public virtual double GetArea() {
            return SideLength1 * SideLength2;
        }

        public virtual double GetPerimeter() {
            return SideLength1 + SideLength2 + SideLength3 + SideLength4;
        }
    }
}
