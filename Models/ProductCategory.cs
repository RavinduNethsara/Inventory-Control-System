using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryControlSystem.Models
{
    public class ProductCategory
    {
        [Key]
        public int categoryID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string categoryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string categoryDescription { get; set; }
    }
}
