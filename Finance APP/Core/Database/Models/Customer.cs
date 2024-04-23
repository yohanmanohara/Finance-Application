using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Finance_APP.Core.Database.Models
{
    internal class Customer: BaseModel
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string ResidentialAddress { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string NICNumber { get; set; }
        public string TINNumber { get; set; }
        public string Occupation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CivilStatus { get; set; }
        public string Nationality { get; set; }
        public string Profession { get; set; }
        public string Designation { get; set; }
        public string Employer { get; set; }
        public string EmplyementStatus { get; set; }
        public DateTime EmployementServiceTimeStart { get; set; }
        public string SpouseProfession { get; set; }
        public string IncomeMethod { get; set; }
        public double IncomeAmount { get; set; }
    }
}
