using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SportsApp
{        
    public class MyDatabase
    {                        
        public double Distance { get; set; }
        public int Quantity { get; set; }
        public string Health { get; set; }

        private DateTime date;
        public DateTime Date
        {
            get
            {               
                return date;
            }
            set
            {
                if (value > DateTime.Now) throw new ArgumentException("День не может быть больше сегодняшнего дня");
                date = value;
            }
        }        
    }    
}
