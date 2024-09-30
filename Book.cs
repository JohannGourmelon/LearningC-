using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_
{
    internal class Book
    {
        // Attributs
        public int BookId { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int RackNo { get; set; }
        public string Status { get; set; } // Par exemple: "Disponible", "Emprunté"
        public string Edition { get; set; }
        public DateTime DateOfPurchase { get; set; }

        // Constructeur
        public Book(int bookId, string author, string name, double price, int rackNo, string status, string edition, DateTime dateOfPurchase)
        {
            BookId = bookId;
            Author = author;
            Name = name;
            Price = price;
            RackNo = rackNo;
            Status = status;
            Edition = edition;
            DateOfPurchase = dateOfPurchase;
        }

        // Méthode pour afficher les détails du livre
        public void DisplayBookDetails()
        {
            Console.WriteLine($"ID du livre : {BookId}");
            Console.WriteLine($"Auteur : {Author}");
            Console.WriteLine($"Nom du livre : {Name}");
            Console.WriteLine($"Prix : {Price}€");
            Console.WriteLine($"Numéro de rack : {RackNo}");
            Console.WriteLine($"Statut : {Status}");
            Console.WriteLine($"Édition : {Edition}");
            Console.WriteLine($"Date d'achat : {DateOfPurchase.ToShortDateString()}");
        }

        // Méthode pour mettre à jour le statut du livre
        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Le statut du livre {Name} a été mis à jour en : {Status}");
        }
    }
}
    