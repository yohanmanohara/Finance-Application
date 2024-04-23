using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Finance_APP.Core.Database.Models
{
    internal class User: BaseModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public string Mobile { get; set; }
        public string NICNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ResidentialAddress { get; set; }
        public string EmployementStatus { get; set; }
        public DateTime EmployementServiceTimeStart { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
