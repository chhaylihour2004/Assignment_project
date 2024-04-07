using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models.Response
{
    public class OrderItemResponse
    {
        
        public string CategoryId { get; set; } 
        public string CategoryName { get; set; } 
        public string BrandId { get; set; }
        public string BrandName { get; set;}
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string Discount { get; set; }
        public string Total {  get; set; }

    }
}
