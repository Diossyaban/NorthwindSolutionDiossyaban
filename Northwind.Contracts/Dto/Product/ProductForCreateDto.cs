using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Northwind.Contracts.Dto.Product
{
    public class ProductForCreateDto
    {
        [Display(Name = "Product Name")]
        [Required]
        [StringLength(50,ErrorMessage ="Product name cannot be longer than 50")]
        public string ProductName { get; set; }

        [Display(Name = "Supplier ID")]
        public int? SupplierId { get; set; }

        [Display(Name = "Category ID")]
        public int? CategoryId { get; set; }

        [Display(Name = "Quantity PerUnit ")]
        public string QuantityPerUnit { get; set; } 

        [Display(Name = "Unit Price")]
        public decimal? UnitPrice { get; set; }
        [Display(Name = "Units In Stock")]
        public short? UnitsInStock { get; set; }

        [Display(Name = "Units On Order")]
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        [Display(Name = "Discontinued")]
        public bool Discontinued { get; set; }
    }
}
