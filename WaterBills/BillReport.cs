using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBills
{
    //Done
    internal class BillReport
    {
        /// <summary>
        /// This is For Print Report Of bill 
        /// </summary>
        /// <param name="id">ID Of Custmer</param>
        /// <param name="db">custmer From Database</param>
        /// <param name="billCalculate">calculate bill</param>
        public static void PrintReport(int id, DB db, BillCalculate billCalculate)
        {
            Console.WriteLine(db[id]);
            Console.WriteLine(
                "Date : " + DateTime.Now.ToString() +"\n\n" +
                "\t\tCurrent : " + billCalculate.Current + "\n" +
                "\t\tPrivous : " + billCalculate.Privous + "\n" +
                "\t\tCunsumption : " + billCalculate.Cunsumption + "\n" +
                "\t\tPrivous Balance : " + billCalculate.PrivousBalance + "\n" +
                "\t\tThe Amount : " + billCalculate.Result + "\n" +
                "---------------------------------------" + "\n" +
                "\t\t\t Thank You ..." 


               );
        }
    }
}
