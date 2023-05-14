using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodOrderAPIWebApp.Models
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Категорія")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Інформація про категорію")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
