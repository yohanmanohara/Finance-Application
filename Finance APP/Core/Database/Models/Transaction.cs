using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Finance_APP.Core.Database.Models
{
    internal class Transaction : BaseModel
    {
		public int AccountId { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
