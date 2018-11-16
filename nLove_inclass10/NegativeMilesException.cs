using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass10
{
    class NegativeMilesException : Exception // ":" - extends!
    {
        private static string _message = "Trips can't be a negative value!";

        public NegativeMilesException() : base(_message) { }// ":" - initiator - takes constructor from the Exception class and adds the message

    }
}
