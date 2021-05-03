using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome To Data Structure Program-------");

            LinkedList list = new LinkedList();//creating object of linkedlist class
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            list.Display();

            Console.Read();
        }
    }
}
