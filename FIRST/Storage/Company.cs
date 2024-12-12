using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    internal class Company
    {
        public int id { get; set; }
        public string Name { get; set; }
        public static List<Storage> Storages { get; set; } = new List<Storage>();
        public List<Hire> Hires { get; set; } = new List<Hire>();


        public Company(string name)
        {
            Name = name;
        }
        public void GetStorage()
        {
            foreach(Storage storage in Storages)
            {

                Console.WriteLine(storage);
            }

        }
        public Storage getStoragebyId(int id)

        {
            Storage storage = Storages.FirstOrDefault(g => g.Id == id);
            return storage;
           
        }
        public void Addstorage(Storage storage)
        {
            Storages.Add(storage);

        }
          public void Getallstorage()
        {
            foreach (Storage storage in Storages)
            {
                Console.WriteLine(storage);
            }

        }

        public static Hire Gethire(int storageid, int customerid, int hirefield)
        {
            Storage storage =Storages.FirstOrDefault(d=> d.Id == storageid);
            if (storage == null)
            {
                Console.WriteLine("404 not found");
                return null;
            }


            return null;
        }
        


    }
}
