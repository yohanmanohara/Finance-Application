using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Finance_APP.Core.Database.Models
{
    internal class PersonalLoan: BaseModel
    {
        public int AccountId { get; set; }
        public string LoanPurpose { get; set; }
        public double LoanAmount { get; set; }
        public DateTime RepaymentPeriodStart { get; set; }
        public DateTime RepaymentPeriodEnd { get; set; }
        public double InterestRate { get; set; }
        public double MonthlyRepaymentAmount { get; set; }
        public double TotalRepaymentAmount { get; set; }
        public string LoanStatus { get; set; }
        public DateTime LoanApprovalDate { get; set; }
        public DateTime LoanDisbursedDate { get; set; }
        public double LoanDisbursedAmount { get; set; }
        public int LoanDisbursedBy { get; set; }
    }
}
