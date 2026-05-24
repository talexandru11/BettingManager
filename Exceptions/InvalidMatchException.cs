using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectPariuri.Exceptions
{
    public class InvalidMatchException : Exception
    {
        public InvalidMatchException(string message) : base(message)
        {

        }
    }
}
