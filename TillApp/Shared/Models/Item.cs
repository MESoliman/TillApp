using System;
using System.Collections.Generic;
using System.Text;

namespace TillApp.Shared.Models
{
    public class Item
    {
        public int ItemId { get; set; }

        public int OrderID { get; set; }
        public virtual Order order { get; set; }

        public int ProductID { get; set; }        
        public virtual Product product { get; set; }

        public int Quantity { get; set; }

        public decimal Cost { get; set; }
    }
}
