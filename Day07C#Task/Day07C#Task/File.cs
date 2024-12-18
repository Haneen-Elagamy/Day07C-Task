using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07C_Task
{
    internal class File:IReadable,IWritable
    {
        public string Name { get; set; }
        public void Read()
        {
            Console.WriteLine($"File name is {Name}");
        }

        public void Write()
        {
            Console.WriteLine("Write method works successfully");
        }
    }
}
