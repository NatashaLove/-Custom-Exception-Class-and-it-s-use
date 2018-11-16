using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nLove_inclass10
{
    class Trip
    {
        private int _miles;
        private int _gallons;

        public Trip() {

            _miles = 0;
            _gallons = 0;
        }

        //extended property

        public int Miles {
            get { return _miles; }
            set {
                if (value<0)
                {
                    NegativeMilesException nme = new NegativeMilesException();// create an exception -which calls constructor wth the message
                    throw (nme); // "throw" is used after the exception object was created - with "new"
                }
                else
                {
                    _miles = value;
                }

            }
        }

        public int Gallons {
            get { return _gallons; }
            set { _gallons = value; }
        }

        public int MPG { get { return Miles / Gallons; } }
    }
}
