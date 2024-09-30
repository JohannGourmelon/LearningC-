using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_
{
    internal class StudyBooks : Book
    {
        // Attribut spécifique aux livres d'étude
        public string Subject { get; set; } // Ex : "Mathématiques", "Physique", etc.

        public StudyBooks(int bookId, string author, string name, double price, int rackNo, string status, string edition, DateTime dateOfPurchase, string subject)
            : base(bookId, author, name, price, rackNo, status, edition, dateOfPurchase)
        {
            Subject = subject;
        }

        public void DisplayStudyBookDetails()
        {
            DisplayBookDetails();
            Console.WriteLine($"Sujet : {Subject}");
        }
    }
}
