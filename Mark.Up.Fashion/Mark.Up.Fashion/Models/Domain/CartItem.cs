using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark.Up.Fashion.Models.Domain
{
    public class CartItem
    {
        [Key]
        public long CartItemId { get; set; }
        [ForeignKey("CartId")]
        public long CartId { get; set; }
        [ForeignKey("ProductId")]
        public long ProductId { get; set; }
        public int Qty { get; set; }
    }
}
