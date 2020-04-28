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
    public partial class Form3 : Form
    {        
        Exercises database = null;
        public Form3()
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
            dateTimePicker1.Value = exercises.Date;
            textBox2.Text = exercises.Quantity.ToString();
            textBox3.Text = exercises.Health;
            textBox1.Text = database.CurrentIndex.ToString();
        }
        private void СоздатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database = new Exercises();
        }       
        private void СохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML файл|*.XML|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database.Save(dialog.FileName);
            }
        }
        private void ЗагрузитьToolStripMenuItem2_Click(object sender, EventArgs e)
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
        private void Button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
            if (f5.DialogResult == DialogResult.OK)
            {
                database.Add(f5.Exercises);
                UpdateInfo();
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            database.Prev();
            UpdateInfo();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            database.Next();
            UpdateInfo();
        }
        private void СоздатьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            database = new Exercises();
        }
        private void СохранитьToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML файл|*.XML|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database.Save(dialog.FileName);
            }
        }
        private void ЗагрузитьToolStripMenuItem2_Click_1(object sender, EventArgs e)
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
    }
}
