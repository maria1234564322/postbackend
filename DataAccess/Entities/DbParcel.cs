using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class DbParcel : Entity
    {
        public long OrderId { get; set; }
        public DbOrder Order { get; set; }
        public decimal EstimatedValue { get; set; }
        public string Description { get; set; }
        public decimal Remittancel { get; set; }
    }
}
