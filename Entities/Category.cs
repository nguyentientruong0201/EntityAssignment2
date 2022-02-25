using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFCoreDay11.Entities
{
    [Table("Category")]
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int CategoryID { get; set; }
        [Column("Name")]
        [Required]
        public string CategoryName { get; set; }
        public ICollection<Product> Products {get; set; }
        
    }
}