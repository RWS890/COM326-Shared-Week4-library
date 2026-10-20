using System;
using System.Linq;

namespace Library
{
    public class Member
    {
        // Private backing fields
        private int memberId;
        private string name;
        private string address;
        private int phone;

        // Public properties
        public int MemberId
        {
            get { return memberId; }
            private set
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error: Member ID must be greater than zero.");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                // Ensure name does not contain any numbers
                if (!string.IsNullOrEmpty(value) && !value.Any(char.IsDigit))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers.");
                }
            }
        }

        public string Address
        {
            get { return address; }

            set
            {
                // Ensure address is not blank
                if (!string.IsNullOrEmpty(value))
                {
                    address = value;
                }
                else
                {
                    Console.WriteLine("Error: Member address cannot be blank.");
                }
            }
        }

        // Phone stored as int; setter validates numeric constraints (digit count etc.)
        public int Phone
        {
            get { return phone; }
            set
            {
                // Validate non-negative
                if (value < 0)
                { 
                    Console.WriteLine("Error: Member phone must be non-negative."); 
                }
                if((value.ToString().Length < 7 || value.ToString().Length > 10))
                {
                    Console.WriteLine("Error: Member phone must contain between 7 and 10 digits.");
                }
                phone = value;
            }
        }

        // Constructor using camel case conventions
        public Member(int memberId, string memberName, string memberAddress, int memberPhone)
        {
            MemberId = memberId;
            Name = memberName;
            Address = memberAddress;
            Phone = memberPhone;
        }

        // Method to display information about a member
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone no: {Phone}");
            Console.WriteLine();
        }
    }
}
