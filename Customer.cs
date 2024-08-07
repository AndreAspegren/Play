using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class Customer
    {
        public int ageonid;
        public int perceivedAge;

        public Customer(int ageonid, int perceivedAge)
        {
            this.ageonid = ageonid;
            this.perceivedAge = perceivedAge;
        }
    }
}
