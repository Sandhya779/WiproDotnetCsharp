using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.StreamReader;

namespace ConsoleApp1
{
    public class FileHandle
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public string Type { get; set; }
        //public FileHandle(int id, string name, string desc,string type)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = desc;
        //    Type = type;
        //}
        //public void Transaction()
        //{
        //    FileStream fi = new FileStream("networking.txt", FileMode.Create, FileAccess.Write);
        //    StreamWriter x = new StreamWriter(fi);
        //    x.WriteLine("ID: " + Id);
        //    x.WriteLine("Name: " + Name);
        //    x.WriteLine("Description: " + Description);
        //    x.WriteLine("Type: " + Type);
        //    x.Close();
        //    fi.Close();
        //}
        public void ReadTransaction()
        {
            FileStream f = new FileStream("networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader y=new StreamReader(f);
            Console.WriteLine(y.ReadToEnd());
            y.Close();
            f.Close();
        }
    }
    
}
