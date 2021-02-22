using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøenOpgave
{
    class Guest
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime TimeArrived { get; set; }
        public int MaxLimit { get; set; } = 10;

        public Guest(string name, int age, DateTime timeArrived)
        {
            Name = name;
            Age = age;
            TimeArrived = timeArrived;
        }

        public Guest() { }
    }
}
