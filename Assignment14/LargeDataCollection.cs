using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    public class LargeDataCollection : IDisposable
    {
        private ArrayList pvtArray = new ArrayList();
        bool disposedvalue;

        public LargeDataCollection(ArrayList inputArray)
        {
            this.pvtArray = inputArray;
        }

        public void addData(object x)
        {
            this.pvtArray.Add(x);
        }

        public void removeData(object x)
        {
            this.pvtArray.Remove(x);
        }

        public void displayData()
        {
            Console.WriteLine("\nThe elements in the list are: ");
            foreach (object x in this.pvtArray)
            {
                Console.WriteLine(x + "\n");
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedvalue)
            {
                pvtArray = null;
                disposedvalue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
