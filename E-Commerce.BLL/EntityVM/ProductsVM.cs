using E_Commerce.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.EntityVM
{
    public class ProductsVM
    {
        public int? id { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [MinLength(3, ErrorMessage = "Min Lin 3")]
        public string name { get; set; }
        public float price { get; set; }
        public string descreption { get; set; }
        //public List<Customer_Oreders_Products> Customer_Oreders_Products { get; set; }
        public int SupplierId { get; set; }
        public Suppliers? Supplier { get; set; }
        public string? Image { get; set; }
    }
}
