using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC_
{
    internal class Faculty : MemberRecord
    {
        // Attribut spécifique pour les enseignants
        public string Department { get; set; } // Ex : "Sciences", "Lettres", etc.

        public Faculty(int memberId, string type, DateTime dateOfMembership, int maxBookLimit, string name, string address, string phoneNo, string department)
            : base(memberId, type, dateOfMembership, maxBookLimit, name, address, phoneNo)
        {
            Department = department;
        }

        public void DisplayFacultyDetails()
        {
            RetrieveMember();
            Console.WriteLine($"Département : {Department}");
        }
    }
}
