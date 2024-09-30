using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_
{
    internal class Transaction
    {
        public int TransId { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DueDate { get; set; }

        public Transaction(int transId, int memberId, int bookId, DateTime dateOfIssue, DateTime dueDate)
        {
            TransId = transId;
            MemberId = memberId;
            BookId = bookId;
            DateOfIssue = dateOfIssue;
            DueDate = dueDate;
        }

        public void CreateTransaction()
        {
            Console.WriteLine("Creating transaction...");
        }

        public void DeleteTransaction()
        {
            Console.WriteLine("Deleting transaction...");
        }

        public void RetrieveTransaction()
        {
            Console.WriteLine("Retrieving transaction...");
        }
    }
}
