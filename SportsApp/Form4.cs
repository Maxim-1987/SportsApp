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
        public MyDatabase Exercises { get; private set; } = new MyDatabase();
        public Form4()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Exercises.Date = dateTimePicker1.Value;
            Exercises.Distance = Convert.ToDouble (textBox1.Text);
            Exercises.Health = textBox2.Text;            
            DialogResult = DialogResult.OK;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }       
    }
}
