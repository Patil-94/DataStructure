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

            LinkList list = new LinkList();//creating object of linkedlist class


            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("\nAdd after 30 : 40");
            list.AddAfterAtPerticulatPosition(30);
            list.Display();
            Console.Read();
        }
    }
}
