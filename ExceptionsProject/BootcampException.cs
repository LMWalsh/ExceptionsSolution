﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsProject {
    public class BootcampException : Exception {

        public BootcampException() : base() { }

        public BootcampException(string message) : base(message) { }

        public BootcampException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}
