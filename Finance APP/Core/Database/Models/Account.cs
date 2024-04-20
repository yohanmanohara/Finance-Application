using Finance_APP.Core.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Finance_APP.Core.Database.Models
{ 
    internal class AccountData : BaseDataType
    {
        public int CustomerId;
        public string Type;
        public string Name;
        public float Balance;

        public AccountData(int id, int customerID, string type, string name, float balance): base(id) {
            CustomerId = customerID;
            Type = type;
            Name = name;
            Balance = balance;
        }
    }

    internal class Account : BaseModel<AccountData>
    {
        public Account() : base("Account") {
        }
    }
}
