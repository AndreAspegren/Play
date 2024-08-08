using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play
{
    internal class Officers
    {
        public void officer1q(CarDriver cardriver)
        {
            Console.WriteLine("Brukte du bilbelte og brukte du ikke telefonen mens du kjørte?");
            if (!cardriver._seatbelton || cardriver._phoneuse) cardriver._ticket = true;
        }

        public void officer2q(CarDriver cardriver)
        {
            Console.WriteLine("Er du full?");
            if (!cardriver._notdrunk) cardriver._ticket = true;
        }
        public void officer3q(CarDriver cardriver)
        {
            Console.WriteLine("Har du gyldig førerkort?");
            if (cardriver._legaqldriversliscense) cardriver._ticket = true;
        }

        public void ticket()
        {
            Console.WriteLine("Du fikk bot");
        }

        public void noticket()
        {
            Console.WriteLine("Du fikk ikke bot");
        }
    }
}
