using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShopLibrary.Models
{
    [Table("tblProducts")]
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfCreate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Discount { get; set; }
        [Required]
        public float Price_vs_Discount { get; set; }

        [Required,ForeignKey("CategoryOf")]
        public int CategoryId { get; set; }

        public Category CategoryOf { get; set; }
    }
}
