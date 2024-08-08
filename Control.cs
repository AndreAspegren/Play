using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play
{
    internal class Control
    {
        private List<CarDriver> _drivers = new()
        {
            new CarDriver(true, false, false, true, 0, false),
            new CarDriver(true, true, false, true, 1, false),
            new CarDriver(true, false, true, true, 2, false)
        };

        private Officers officers = new();

        public void check()
        {
            for (var i = 0; i < _drivers.Count; i++)
            {
                if (_drivers[i]._officer == 0) officers.officer1q(_drivers[i]);
                if (_drivers[i]._officer == 1) officers.officer2q(_drivers[i]);
                if (_drivers[i]._officer == 2) officers.officer3q(_drivers[i]);
                Console.ReadKey();
            }

            Console.Clear();
            for (var i = 0; i < _drivers.Count; i++)
            {
               if (_drivers[i]._ticket) officers.ticket();
               else officers.noticket();
            }
        }
    }
}