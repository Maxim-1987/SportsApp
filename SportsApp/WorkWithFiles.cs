using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SportsApp
{
    public class WorkWithFiles
    {                    
        Run r = new Run();
        public void Save(string fileName)
        {            
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<MyDatabase>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, r.list);
            fStream.Close();
            r.index = 0;
        }
        public void Load(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<MyDatabase>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            r.list = (List<MyDatabase>)xmlFormat.Deserialize(fStream);
            fStream.Close();
            r.index = 0;
        }
    }
}
