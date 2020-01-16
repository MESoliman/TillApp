using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TillApp.Shared.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage ="Must add order name")]
        [StringLength(100, ErrorMessage = "Order Name must be between less than 100 character.")]
        public string OrderName { get; set; }

        [Range(1, 100000, ErrorMessage = "Amount Cannot be zero")]
        public decimal Amount { get; set; }

        public bool IsPaid { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
