using System;
using System.Collections.Generic;
using TPC_;

class Program
{
    static void Main(string[] args)
    {
        // Création des instances de Journals
        List<Journals> journalsList = new List<Journals>
        {
            new Journals(1, "Auteur1", "Journal1", 15.99, 101, "Disponible", "1ère édition", DateTime.Now, "Scientifique"),
            new Journals(2, "Auteur2", "Journal2", 10.99, 102, "Emprunté", "2ème édition", DateTime.Now, "Culturel"),
            new Journals(3, "Auteur3", "Journal3", 12.99, 103, "Disponible", "1ère édition", DateTime.Now, "Médical"),
            new Journals(4, "Auteur4", "Journal4", 8.99, 104, "Emprunté", "3ème édition", DateTime.Now, "Technologique"),
            new Journals(5, "Auteur5", "Journal5", 5.99, 105, "Disponible", "1ère édition", DateTime.Now, "Littéraire"),
            new Journals(6, "Auteur6", "Journal6", 18.99, 106, "Disponible", "2ème édition", DateTime.Now, "Philosophique"),
            new Journals(7, "Auteur7", "Journal7", 20.99, 107, "Disponible", "1ère édition", DateTime.Now, "Historique"),
            new Journals(8, "Auteur8", "Journal8", 22.99, 108, "Disponible", "2ème édition", DateTime.Now, "Psychologie"),
            new Journals(9, "Auteur9", "Journal9", 17.99, 109, "Emprunté", "1ère édition", DateTime.Now, "Politique"),
            new Journals(10, "Auteur10", "Journal10", 19.99, 110, "Disponible", "1ère édition", DateTime.Now, "Économie")
        };

        // Création des instances de StudyBooks
        List<StudyBooks> studyBooksList = new List<StudyBooks>
        {
            new StudyBooks(11, "Auteur1", "Mathématiques de base", 25.99, 201, "Disponible", "1ère édition", DateTime.Now, "Mathématiques"),
            new StudyBooks(12, "Auteur2", "Physique générale", 35.99, 202, "Disponible", "2ème édition", DateTime.Now, "Physique"),
            new StudyBooks(13, "Auteur3", "Programmation en C#", 45.99, 203, "Emprunté", "1ère édition", DateTime.Now, "Informatique"),
            new StudyBooks(14, "Auteur4", "Biologie cellulaire", 55.99, 204, "Disponible", "3ème édition", DateTime.Now, "Biologie"),
            new StudyBooks(15, "Auteur5", "Chimie organique", 65.99, 205, "Disponible", "2ème édition", DateTime.Now, "Chimie"),
            new StudyBooks(16, "Auteur6", "Électronique", 75.99, 206, "Disponible", "1ère édition", DateTime.Now, "Électronique"),
            new StudyBooks(17, "Auteur7", "Statistiques appliquées", 25.99, 207, "Emprunté", "2ème édition", DateTime.Now, "Statistiques"),
            new StudyBooks(18, "Auteur8", "Algorithmique", 55.99, 208, "Disponible", "3ème édition", DateTime.Now, "Informatique"),
            new StudyBooks(19, "Auteur9", "Mécanique des fluides", 85.99, 209, "Disponible", "1ère édition", DateTime.Now, "Physique"),
            new StudyBooks(20, "Auteur10", "Thermodynamique", 95.99, 210, "Emprunté", "2ème édition", DateTime.Now, "Chimie")
        };

        // Création des instances de Magazines
        List<Magazines> magazinesList = new List<Magazines>
        {
            new Magazines(21, "Editeur1", "Magazine1", 5.99, 301, "Disponible", "1ère édition", DateTime.Now, "Mensuel"),
            new Magazines(22, "Editeur2", "Magazine2", 6.99, 302, "Disponible", "2ème édition", DateTime.Now, "Hebdomadaire"),
            new Magazines(23, "Editeur3", "Magazine3", 7.99, 303, "Disponible", "1ère édition", DateTime.Now, "Quotidien"),
            new Magazines(24, "Editeur4", "Magazine4", 8.99, 304, "Emprunté", "1ère édition", DateTime.Now, "Mensuel"),
            new Magazines(25, "Editeur5", "Magazine5", 9.99, 305, "Disponible", "2ème édition", DateTime.Now, "Hebdomadaire"),
            new Magazines(26, "Editeur6", "Magazine6", 10.99, 306, "Disponible", "1ère édition", DateTime.Now, "Mensuel"),
            new Magazines(27, "Editeur7", "Magazine7", 11.99, 307, "Disponible", "2ème édition", DateTime.Now, "Mensuel"),
            new Magazines(28, "Editeur8", "Magazine8", 12.99, 308, "Disponible", "1ère édition", DateTime.Now, "Mensuel"),
            new Magazines(29, "Editeur9", "Magazine9", 13.99, 309, "Disponible", "1ère édition", DateTime.Now, "Quotidien"),
            new Magazines(30, "Editeur10", "Magazine10", 14.99, 310, "Emprunté", "1ère édition", DateTime.Now, "Mensuel")
        };

        // Tests sur les méthodes des classes dérivées (Journals, StudyBooks, Magazines)
        Console.WriteLine("=== Détails Journaux ===");
        foreach (var journal in journalsList)
        {
            journal.DisplayJournalDetails();
        }

        Console.WriteLine("\n=== Détails Livres d'Étude ===");
        foreach (var studyBook in studyBooksList)
        {
            studyBook.DisplayStudyBookDetails();
        }

        Console.WriteLine("\n=== Détails Magazines ===");
        foreach (var magazine in magazinesList)
        {
            magazine.DisplayMagazineDetails();
        }

        // Création de quelques instances de Student et Faculty pour des tests
        List<Student> students = new List<Student>
        {
            new Student(1, "Étudiant", DateTime.Now, 5, "Étudiant 1", "Adresse 1", "0101010101", "Informatique"),
            new Student(2, "Étudiant", DateTime.Now, 5, "Étudiant 2", "Adresse 2", "0202020202", "Mathématiques"),
            new Student(3, "Étudiant", DateTime.Now, 5, "Étudiant 3", "Adresse 3", "0303030303", "Physique")
        };

        List<Faculty> faculties = new List<Faculty>
        {
            new Faculty(4, "Enseignant", DateTime.Now, 10, "Professeur 1", "Adresse 4", "0404040404", "Sciences"),
            new Faculty(5, "Enseignant", DateTime.Now, 10, "Professeur 2", "Adresse 5", "0505050505", "Lettres"),
            new Faculty(6, "Enseignant", DateTime.Now, 10, "Professeur 3", "Adresse 6", "0606060606", "Informatique")
        };

        // Test des méthodes associées aux membres (Students et Faculties)
        Console.WriteLine("\n=== Détails des Étudiants ===");
        foreach (var student in students)
        {
            student.DisplayStudentDetails();
            student.IncreaseBooksIssued(); // Test de l'augmentation des livres empruntés
        }

        Console.WriteLine("\n=== Détails des Enseignants ===");
        foreach (var faculty in faculties)
        {
            faculty.DisplayFacultyDetails();
            faculty.IncreaseBooksIssued(); // Test de l'augmentation des livres empruntés
        }
    }
}
