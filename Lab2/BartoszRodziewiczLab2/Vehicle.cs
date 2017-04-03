using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartoszRodziewiczLab2
{
    public class Vehicle : Base, IMovable
    {
        public int NumberOfWheels { get; set; }

        public string Move()
        {
            return "Ja jadeeeee! :)";
        }
    }
}
