using System;
using System.Collections.Generic;
using System.Text;

namespace TillApp.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ImgSrc { get; set; }

        public string ProductName { get; set; }

        public Decimal Price { get; set; }
    }
}
