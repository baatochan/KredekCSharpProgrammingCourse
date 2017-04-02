using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartoszRodziewiczLab2
{
    class myClass : Base
    {
        public string Name { get; set; }
        public int Number { get; set; }

        private string _address;
        private string _city;

        public string getAddress() {
            return _address;
        }

        public void setAddress(string address){
            _address = address;
        }

        public DaysOfAvalaibility daysOfAvalaibility;
        public DaysOfAvalaibility daysOfAvalaibility2;
    }
}
