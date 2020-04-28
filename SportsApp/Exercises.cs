using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SportsApp
{
    public class Exercises
    {
        public List<MyDatabase> list;
        public int index;
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
        public void Add(MyDatabase exercises)
        {
            list.Add(exercises);
            index = list.Count - 1;
        }
        public void Remove()
        {
            list.RemoveAt(index);
            Prev();
        }
        public Exercises()
        {
            list = new List<MyDatabase>();
            index = -1;
        }
        public MyDatabase CurrentExercises
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
        public void Save(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<MyDatabase>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
            index = 0;
        }
        public void Load(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<MyDatabase>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<MyDatabase>)xmlFormat.Deserialize(fStream);
            fStream.Close();
            index = 0;
        }
    }
}


   

