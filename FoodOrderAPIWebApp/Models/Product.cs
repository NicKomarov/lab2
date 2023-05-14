using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodOrderAPIWebApp.Models
{
    public class Product
    {
        public Product()
        {
            MenuProducts = new List<MenuProduct>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Продукт")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Інформація про продукт")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Ціна")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Кількість")]
        public int Quantity { get; set;}

        [Column("CategoryID")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<MenuProduct> MenuProducts { get; set; }
    }
}
