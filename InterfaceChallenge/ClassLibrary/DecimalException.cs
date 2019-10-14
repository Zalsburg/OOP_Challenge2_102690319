using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary {
    public class DecimalException : Exception {
        public DecimalException (string message) : base(message) {
        }
    }
}
