using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShopLibrary.Models
{
    [Table("tblCategories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(30)]
        public string Name { get; set; }

        public virtual ICollection<Products> ProductsOf { get; set; }
    }
}
