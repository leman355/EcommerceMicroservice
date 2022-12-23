using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Entities.DTOs
{
    public class OrderListDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<OrderItemDTO> OrderItems { get; set; }
    }
}
