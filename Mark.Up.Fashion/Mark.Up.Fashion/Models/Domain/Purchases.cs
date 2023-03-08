using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark.Up.Fashion.Models.Domain
{
    public class Purchases
    {
        [Key]
        public long PurchaseId { get; set; }
        [Required]
        public bool Purchased { get;}
        [Required]
        public string UserName { get; set; }
        [Required]
        public string NamesOfProducts { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedDate { get; set;} = DateTime.Now;        
    }
}
