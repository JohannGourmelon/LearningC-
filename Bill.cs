using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_
{
    internal class Bill
    {
        public int BillNo { get; set; }
        public int Date { get; set; }
        public int MemberId { get; set; }
        public double Amount { get; set; }

        public Bill(int billNo, int date, int memberId, double amount)
        {
            BillNo = billNo;
            Date = date;
            MemberId = memberId;
            Amount = amount;
        }

        public void BillCreate()
        {
            Console.WriteLine("Bill created.");
        }

        public void BillUpdate()
        {
            Console.WriteLine("Bill updated.");
        }
    }
}
