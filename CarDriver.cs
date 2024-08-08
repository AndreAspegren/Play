using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play
{
    internal class CarDriver
    {
        public bool _seatbelton { get; private set; }
        public bool _phoneuse { get; private set; }
        public bool _notdrunk { get; private set; }
        public bool _legaqldriversliscense { get; private set; }
        public int _officer { get; set; }
        public bool _ticket = false; 

        public CarDriver(bool seatbelton, bool phoneuse, bool notdrunk, bool legaqldriversliscense, int officer, bool ticket)
        {
            _seatbelton = seatbelton;
            _phoneuse = phoneuse;
            _notdrunk = notdrunk;
            _legaqldriversliscense = legaqldriversliscense;
            _officer = officer;
            _ticket = ticket;
        }
    }
}
