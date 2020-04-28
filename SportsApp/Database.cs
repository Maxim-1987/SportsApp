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
    public class Run
    {        
        List<MyDatabase> list;
        int index;
        public int CurrentIndex
        {
            get
            {
                return index;
            }
        }
        public void Next()
        {
            if (list.Count > index + 1)
                index++;
        }
        public void Prev()
        {
            if (index > 0)
                index--;
        }
        public void Add(MyDatabase run)
        {
            list.Add(run);
            index = list.Count - 1;
        }
        public void Remove()
        {
            list.RemoveAt(index);
            Prev();
        }
        public Run()
        {
            list = new List<MyDatabase>();
            index = -1;
        }
        public MyDatabase CurrentRun
        {
            get
            {
                try
                {
                    return list[index];
                }
                catch
                {
                    return null;
                }
            }
        }
        public void Save (string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<MyDatabase>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
            index = 0;
        }
        public void Load (string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<MyDatabase>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<MyDatabase>)xmlFormat.Deserialize(fStream);
            fStream.Close();
            index = 0;
        }
    }
}
