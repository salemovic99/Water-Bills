using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DB db = new DB();

            BillCalculate billCalculate = new BillCalculate();
            billCalculate.CalculateBill(50, 50, 1000);
            BillReport.PrintReport(3, db, billCalculate);
            Console.ReadKey();

        }
    }
}
