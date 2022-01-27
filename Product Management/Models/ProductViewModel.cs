using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Image { get; set; }
        public string Description { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}
