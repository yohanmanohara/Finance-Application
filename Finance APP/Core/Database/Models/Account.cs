using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Finance_APP.Core.Database.Models
{
    internal class Account : BaseModel
    {
        public int CustomerId { get; set; }
        public string Type { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }
    }
}
