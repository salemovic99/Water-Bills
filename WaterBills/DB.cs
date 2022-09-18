using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBills
{
    //Doing
    class DB
    {
        public List<Custmer> CustmerList;

        public DB()
        {
            CustmerList = new List<Custmer>();

            CustmerList.Add(new Custmer
            {
                ID = 1,
                Name = "salem",
                Phone = "++967771789381",
                Address = new Address
                { City = "mukallla", Street = "alslam", HouseNumbers = 200 },
                Email = "s@gmail.com",
                PrivousBalance = 0m
            });

            CustmerList.Add(new Custmer
            {
                ID = 2,
                Name = "omer",
                Phone = "++967771789382",
                Address = new Address
                { City = "mukallla", Street = "alslam", HouseNumbers = 201 },
                Email = "o@gmail.com",
                PrivousBalance = 0m

            });

            CustmerList.Add(new Custmer
            {
                ID = 3,
                Name = "Ahmed",
                Phone = "++967771789383",
                Address = new Address
                { City = "mukallla", Street = "alslam", HouseNumbers = 202 },
                Email = "a@gmail.com",
                PrivousBalance = 0m

            });

            CustmerList.Add(new Custmer
            {
                ID = 4,
                Name = "maher",
                Phone = "++967771789384".ToString(),
                Address = new Address
                { City = "mukallla", Street = "alslam", HouseNumbers = 203 },
                Email = "m@gmail.com",
                PrivousBalance = 0m

            });
        }

        public string this[int index]
        {
            get
            {
                //return CustmerList.FirstOrDefault(custmer => custmer.ID == index).Name.ToString();
                return "\t ID : " + CustmerList[index].ID.ToString() +"\n"+
                    "\tName : " + CustmerList[index].Name.ToString() + "\n" +
                    "\tEmail : " + CustmerList[index].Email.ToString() + "\n" +
                    "\tCity : " + CustmerList[index].Address.City.ToString() + "\n" +
                    "\tStreet : " + CustmerList[index].Address.Street.ToString() + "\n" +
                    "\tHouseNumber : " + CustmerList[index].Address.HouseNumbers.ToString();
            }
     
        }

        public void EditPrivousBalance(int id, decimal amount)
        {
            Console.WriteLine();
        }



    }
}
