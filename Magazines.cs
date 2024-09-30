using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_
{
    internal class Magazines : Book
    {
        // Attribut spécifique aux magazines
        public string PublicationFrequency { get; set; } // Ex : "Mensuel", "Hebdomadaire", etc.

        public Magazines(int bookId, string author, string name, double price, int rackNo, string status, string edition, DateTime dateOfPurchase, string publicationFrequency)
            : base(bookId, author, name, price, rackNo, status, edition, dateOfPurchase)
        {
            PublicationFrequency = publicationFrequency;
        }

        public void DisplayMagazineDetails()
        {
            DisplayBookDetails();
            Console.WriteLine($"Fréquence de publication : {PublicationFrequency}");
        }
    }
}
