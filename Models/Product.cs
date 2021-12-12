using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryControlSystem.Models
{
    public class Product
    {
        [Key]
        public int productID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string productName { get; set; }

        public int productCategory { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string productDescription { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string productPrice { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string productQuantity { get; set; }



    }
}
