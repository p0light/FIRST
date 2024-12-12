using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    internal class Storage
    {
        private static int _id;
        public int Id { get; set; }
        public string name { get; set; }
        public int storagefield { get; set; }
        public int Emptyarea {  get; set; }
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public Storage(string name, int storagefield)
        {
            Id = ++_id;
            name = name;
            storagefield = storagefield;
            Emptyarea = storagefield;
        }

        public override string ToString()
        {
            return $"{Id}.{name}";
        }
        

        public void Getcustomer()
        {
            foreach (Customer customer in Customers)
            {
                Console.WriteLine(customer);
            }
        }
        public void  addcustomer(Customer customer)
        {
            if (Emptyarea == 0)
            {
                
                throw new Exception("This Storage is full");

            }
            else
            {
                Customers.Add(customer);
            }
            
        }
        

        
        

       

          

       


    }
}
