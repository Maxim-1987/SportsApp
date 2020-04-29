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
    public partial class Form2 : Form
    {

        Exercises database = null;       
        public Form2()
        {
            InitializeComponent();
        }
        private void UpdateInfo()
        {
            MyDatabase exercises = database.CurrentExercises;
            if (exercises == null)
            {               
                textBox2.Text = "";
                textBox3.Text = "";
                textBox1.Text = "";
                return;
            }
            dateTimePicker.Value = exercises.Date;
            textBox2.Text = exercises.Distance.ToString();
            textBox3.Text = exercises.Health;
            textBox1.Text = database.CurrentIndex.ToString();
        }       
        private void Btn1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            if(f4.DialogResult == DialogResult.OK)
            {
                database.Add(f4.Exercises);
                UpdateInfo();                
            }
        } 
        private void СоздатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database = new Exercises();
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            database.Prev();
            UpdateInfo();
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            database.Next();
            UpdateInfo();
        }
        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML файл|*.XML|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database.Save(dialog.FileName);
            }
        }
        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML файл|*.XML|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database = new Exercises();
                database.Load(dialog.FileName);
                UpdateInfo();
            }
        }

        private void СтатистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
