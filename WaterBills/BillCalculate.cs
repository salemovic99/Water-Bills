using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBills
{
    //Done

    /// <summary>
    /// This is For Calculate water bills 
    /// </summary>
    internal class BillCalculate
    {
        public int Current { get; set; }
        public int  Privous { get; set; }
        public decimal Cunsumption { get; set; }
        public decimal Result { get; set; }
        public decimal PrivousBalance { get; set; }

        /// <summary>
        /// From 0 To 10 50YR
        /// From 11 To 20 85YR
        /// From 21 To 30 110YR
        /// From 31 To UP 140SR
        /// </summary>
        /// <param name="current"></param>
        /// <param name="privous"></param>
        /// <param name="privous_balance"></param>
        public void CalculateBill(int current, int privous, decimal privous_balance)
        {
             Current = current;
             Privous = privous;
             PrivousBalance = privous_balance;
            if (Current >= Privous)
            {
                Cunsumption = current - privous;

                if (Cunsumption > 0 && Cunsumption <= 10)
                {
                    Result = Cunsumption * 50;
                }
                else if (Cunsumption >= 11 && Cunsumption <= 20)
                {
                    Result = Cunsumption * 85;
                }
                else if (Cunsumption >= 21 && Cunsumption <= 30)
                {
                    Result = Cunsumption * 110;
                }
                else if (Cunsumption > 30)
                {
                    Result = Cunsumption * 140;
                }
                Result += PrivousBalance;
            }
            else
            {
                Console.WriteLine("Current Must Be Greater Or Equal Than Privous");
            }
        }
    }
}
