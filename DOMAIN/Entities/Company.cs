
using ENOCA.DOMAIN.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENOCA.DOMAIN.Entities
{
    public class Company : BaseEntity
    {
        public int OrderId { get; set; }
        public bool OrderStatus { get; set; } //bool
        public DateTime OrderStartTime { get; set; } //DateTime
        public DateTime OrderFinishTime { get; set; } //DateTime

        //public Order Order { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
