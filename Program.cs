using System;

namespace Clope_mash
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var rowData in DataToIenum.TransactionCharList("agaricus-lepiota.data"))
            {
                foreach (var s in rowData) Console.Write(s, " ");
                Console.WriteLine();
            }
                
            Console.WriteLine("Hello World!");

            
        }
    }
}
