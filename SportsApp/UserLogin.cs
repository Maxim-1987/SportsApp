using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsApp
{
    class UserLogin
    {        
        public string Name { get; set; }         
        public void Welcome ()
        {
             MessageBox.Show ("Приветствуем Вас  в приложении " + Name);         
        }
    }
}
