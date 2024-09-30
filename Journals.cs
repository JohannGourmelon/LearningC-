using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_
{
    internal class Journals : Book
    {
     // Attribut spécifique aux journaux
    public string JournalType { get; set; } // Ex : "Scientifique", "Culturel", etc.

    public Journals(int bookId, string author, string name, double price, int rackNo, string status, string edition, DateTime dateOfPurchase, string journalType)
        : base(bookId, author, name, price, rackNo, status, edition, dateOfPurchase)
    {
        JournalType = journalType;
    }

    public void DisplayJournalDetails()
    {
        DisplayBookDetails();
        Console.WriteLine($"Type de journal : {JournalType}");
    }
    }

}
