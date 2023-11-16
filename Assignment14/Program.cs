using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Program
    {   
        
        static void Main(string[] args)
        {
            ArrayList listx = new ArrayList();
            Console.WriteLine("Enter the number of elements to be added to the list");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements one by one");
            for (int i=0; i<len; i++)
            {
                listx.Add(Console.ReadLine());
            }
            LargeDataCollection ldc = new LargeDataCollection(listx);
            Console.WriteLine("Enter the element to be added");
            ldc.addData(Console.ReadLine() );
            Console.WriteLine("Enter the element to be removed");
            ldc.removeData(Console.ReadLine());
            Console.WriteLine("All the elements of the array list are displayed: ");
            ldc.displayData();
            ldc.Dispose();
            Console.ReadKey();  
        }
    }
}
