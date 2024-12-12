using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    internal class Customer
    {
        private static int _id;
        public int Id { get; set; }
       public string Name {  get; set; }
        public string Surname {  get; set; }
        

        public Customer(String name, string surname)
        {
            Id = _id++;
            Name = name;
            Surname = surname;
            
        }
        
    }
    
}
