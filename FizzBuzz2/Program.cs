using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new list
            ListWithChangedEvent list = new ListWithChangedEvent();

            // creeat a class that listens for when the list is changed
            EventListener listener = new EventListener(list);

            list.Print();
            list.FizzBuzz();
            list.Print();

            
            listener.Detatch();
            
            Console.ReadKey();
        }
    }
}
