using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFCoreDay11.Entities
{
    [Table("Product")]

    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int ProductID { get; set; }
        [Column("Name")]
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Manufacture { get; set; }
        public int CategoryID { get; set; }
        public Category category {get; set; }
        
    }
}