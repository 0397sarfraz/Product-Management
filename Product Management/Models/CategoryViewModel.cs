using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public class CategoryViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Image { get; set; }
        public bool IsActive { get; set; }
    }
}
