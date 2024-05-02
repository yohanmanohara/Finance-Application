using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_APP.Core.Database.Models
{
    internal class Test : BaseModel
    {
        public string Name { get; set; }

        public Test(int id, string name): base()
        {
            this._table = "Test";

            this.Id = id;
            this.Name = name;
        }

        public Test()
        {
            this._table = "Test";
        }
    }
}
