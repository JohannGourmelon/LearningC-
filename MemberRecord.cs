using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_
{
    internal class MemberRecord
    {
        public int MemberId { get; set; }
        public string Type { get; set; }
        public DateTime DateOfMembership { get; set; }
        public int NoOfBooksIssued { get; set; }
        public int MaxBookLimit { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }

        public MemberRecord(int memberId, string type, DateTime dateOfMembership, int maxBookLimit, string name, string address, string phoneNo)
        {
            MemberId = memberId;
            Type = type;
            DateOfMembership = dateOfMembership;
            MaxBookLimit = maxBookLimit;
            Name = name;
            Address = address;
            PhoneNo = phoneNo;
        }

        public void RetrieveMember()
        {
            Console.WriteLine("Retrieving member details...");
        }

        public void IncreaseBooksIssued()
        {
            if (NoOfBooksIssued < MaxBookLimit)
            {
                NoOfBooksIssued++;
                Console.WriteLine("Books issued increased.");
            }
            else
            {
                Console.WriteLine("Cannot issue more books, limit reached.");
            }
        }

        public void DecreaseBooksIssued()
        {
            if (NoOfBooksIssued > 0)
            {
                NoOfBooksIssued--;
                Console.WriteLine("Books issued decreased.");
            }
        }

        public void PayBill()
        {
            Console.WriteLine("Paying bill...");
        }
    }
}
