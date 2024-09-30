using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_
{
    internal class Librarian
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public Librarian(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public void SearchBook()
        {
            Console.WriteLine("Searching for a book...");
        }

        public void VerifyMember()
        {
            Console.WriteLine("Verifying member...");
        }

        public void IssueBook()
        {
            Console.WriteLine("Issuing book...");
        }

        public void CalculateFine()
        {
            Console.WriteLine("Calculating fine...");
        }

        public void CreateBill()
        {
            Console.WriteLine("Creating bill...");
        }

        public void ReturnBook()
        {
            Console.WriteLine("Returning book...");
        }
    }
}
