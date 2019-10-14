using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary {
    public class InvalidInputException : Exception {
        public InvalidInputException(string message) : base(message) { 
        }
    }
}
