using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class Butikk
    {
        private int time;
        Random random;
        private Checks check = new();
        public List<Customer> Customers { get; private set; } = new();
        public void kjøp()
        {
            while (true)
            {
                addCustomer(); ;
                if (!check.willing()) continue;
                if (!check.open(time)) continue;
                if (!check.age(Customers[Customers.Count - 1])) continue;
                buybeer();
            }
        }

        private void addCustomer()
        {
            var perceivedAge = random.Next(0, 100);
            Customers.Add(new Customer(perceivedAge, random.Next(perceivedAge - 5, perceivedAge + 5)));
        }

        private void buybeer()
        {
            Console.WriteLine("Her har du en øl");
            Console.ReadKey();
        }
    }
}
