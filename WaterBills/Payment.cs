using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBills
{
    //Done
    internal abstract class Payment
    {
        public abstract void Pay(int id, DB custmer);
    }
}
