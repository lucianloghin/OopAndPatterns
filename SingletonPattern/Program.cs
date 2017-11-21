using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => Console.WriteLine(SingletonClass.Instance.GetHashCode()));
            Task.Factory.StartNew(() => Console.WriteLine(SingletonClass.Instance.GetHashCode()));
            Console.ReadLine();
        }
    }
}
