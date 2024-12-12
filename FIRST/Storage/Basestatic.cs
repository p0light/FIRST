using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    internal class Basestatic
    {
        public static int EnterChoosens()
        {
            Console.WriteLine("Click 0 for exit");
            Console.WriteLine("Click 1 for add storage to Company");
            Console.WriteLine("Click 2 for Add Customer to Storage");
            Console.WriteLine("Click 3 for Hire Storage");
            int result = int.Parse(Console.ReadLine());

            return  result;
        }
        public static  int EnterStorageid()
        {
            Console.WriteLine("Enter Storage id");
            int storageid = int.Parse(Console.ReadLine());
            return storageid;
        }
         public static Storage EnterStoragedetails()
        {
            Console.WriteLine("Enter storage name");
            String Storagename = Console.ReadLine();
            Console.WriteLine("Set Storage field");
            int storagefield = int.Parse(Console.ReadLine());
            Storage storage = new Storage(Storagename, storagefield);
            return storage;
        }
        public static Customer EnterCustomerdetails()
        {
            Console.WriteLine("enter customer name");
                string name = Console.ReadLine();
            Console.WriteLine("enter customer surname");
                 string surname = Console.ReadLine();
            Customer customer = new Customer(name, surname);
            return customer;
        }

    }
}
