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
    public partial class Form1 : Form
    {
        UserLogin us = new UserLogin();
        MyDatabase db = new MyDatabase();
        public Form1()
        {
            InitializeComponent();
            cbList.Items.AddRange(new string[] { "Бег", "Подтягивания" });
            tbName.Text = us.Name;
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            us.Name = tbName.Text;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();            
            if (cbList.SelectedIndex == 0)
            {                
                f2.Show();
            }
            if (cbList.SelectedIndex == 1)
            {                
                f3.Show();
            }                
        }
        private void BtnOk2_Click(object sender, EventArgs e)
        {            
            us.Welcome();
        }       
    }
}
