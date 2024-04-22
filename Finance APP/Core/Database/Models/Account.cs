using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
CREATE TABLE [dbo].[Account]
(
	[Id]         INT        NOT NULL PRIMARY KEY, 
    [CustomerId] INT        FOREIGN KEY REFERENCES [dbo].[Customer](Id),
    [Type]       NCHAR(30)  NOT NULL, 
    [Balance]    REAL       NOT NULL, 
    [Name]       NCHAR(300) NOT NULL
);

 */

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
