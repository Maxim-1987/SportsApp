using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsApp
{
    internal abstract class Statistics
    {        
        protected double _Ex;
        protected Statistics (double ex)
            {
            _Ex = ex;            
            }
        public abstract double SumExercises(double ex);
        
        
    }
}
