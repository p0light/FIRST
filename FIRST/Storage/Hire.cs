using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    internal class Hire
    {
        private int _id;
        public int Id { get; set; }
       
        public int customerid {  get; set; }
        public int storageid {  get; set; }

        public  int hirefield {  get; set; }

        public Hire(int customerid, int storageid, int hirefield)
        {
            
            
            hirefield = hirefield;
            customerid = customerid;
            storageid = storageid;
        }
       
    }
}
