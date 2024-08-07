using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class Checks
    {
        private Random random = new();

        internal bool willing()
        {
            Console.Clear();
            Console.WriteLine("Vil du kjøpe øl");
            var input = Console.ReadLine();
            if (input == "ja") return true;
            return false;
        }

        internal bool open(int time)
        {
            Console.Clear();
            time = random.Next(0, 24);
            if (time < 8 || time > 20)
            {
                Console.WriteLine("Det er desverre stengt");
                Console.ReadKey();
                return false;
            }
            return true;
        }

        internal bool age(Customer customer)
        {
            Console.Clear();
            customer.perceivedAge = random.Next(0, 100);
            customer.ageonid = random.Next(customer.perceivedAge - 5, customer.perceivedAge + 5);

            if (customer.perceivedAge >= 25) return true;

            Console.WriteLine("Kan du vise meg id");
            if (Console.ReadLine() != "ja") return false;

            if (customer.ageonid >= 18) return true;

            Console.Clear();
            Console.WriteLine($"Du er for ung. Alderen på ID'en er {customer.ageonid}.");
            Console.ReadKey();
            return false;
        } 
    }
}
