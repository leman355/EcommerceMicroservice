using CorePackage.Entities;
using CorePackage.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
