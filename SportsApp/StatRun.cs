using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsApp
{
    class StatRun:Statistics
    {
        public StatRun(double distance)
            : base(distance)
        {

        }

        public override double SumExercises(double distance)
        {            
            double sum = +distance;
            return sum;
        }        
    }
}
