using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary {
    public class Circle : Shape, IShapeCalc {
        public double Pi = Math.PI;
        public double Radius;

        //public Circle (string colour, double radius) : base(colour) {
        //    Pi = Math.PI;
        //    Radius = radius;
        //}

        public double GetArea() {
            return Pi * Radius * Radius;
        }
        public double GetPerimeter() {
            return Pi * 2 * Radius;
        }
    }
}
