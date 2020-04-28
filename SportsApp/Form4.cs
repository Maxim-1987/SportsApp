using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsApp
{
    public partial class Form4 : Form
    {           
        public MyDatabase Run { get; private set; } = new MyDatabase();
        public Form4()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Run.Date = dateTimePicker1.Value;
            Run.Distance = Convert.ToDouble (textBox1.Text);
            Run.Health = textBox2.Text;            
            DialogResult = DialogResult.OK;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }       
    }
}
