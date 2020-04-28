using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsApp
{
    class Statistics
    {
        public int _Rate { get; private set; }
        public int _Id { get; private set; }
        public string _Name { get; private set; }
        public float _MonthlyPayment { get; set; }
        protected Statistics(int rate, int id, string name)
        {
            _Rate = rate;
            _Id = id;
            _Name = name;
        }
    }
}
