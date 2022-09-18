using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBills
{
    //Done
    internal class Custmer
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }

        private string email;
        public decimal PrivousBalance { get; set; }


        public string Email
        {
            get { return email; }
            set 
            {
               // if (email.Contains('@') && email.EndsWith(".com"))
                //{
                    email = value;
               //}
            }
        }

    }

    
}
