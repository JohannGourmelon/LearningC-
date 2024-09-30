using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_
{
    internal class Student : MemberRecord
    {
        // Attribut spécifique pour les étudiants
        public string Course { get; set; } // Ex : "Informatique", "Littérature", etc.

        public Student(int memberId, string type, DateTime dateOfMembership, int maxBookLimit, string name, string address, string phoneNo, string course)
            : base(memberId, type, dateOfMembership, maxBookLimit, name, address, phoneNo)
        {
            Course = course;
        }

        public void DisplayStudentDetails()
        {
            RetrieveMember();
            Console.WriteLine($"Cours suivi : {Course}");
        }
    }
}
