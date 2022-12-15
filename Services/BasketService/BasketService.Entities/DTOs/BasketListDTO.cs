using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.Entities.DTOs
{
    public class BasketListDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<BasketItemDTO> BasketItems { get; set; }
    }
}