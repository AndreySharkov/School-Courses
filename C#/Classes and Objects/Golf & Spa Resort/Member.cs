using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf___Spa_Resort
{
    internal class Member : Customer
    {
        public int MembershipID { get; set; }
        public Member(string firstName, string lastName, int membershipID)
            : base(firstName, lastName)
        {
            MembershipID = membershipID;
        }
        

        public string GetMemberCard(string freeAccess)  
        {

            return $"Member {FirstName} {LastName} with membership number {MembershipID} gets free access to the {freeAccess}.";
        }
    }
}
