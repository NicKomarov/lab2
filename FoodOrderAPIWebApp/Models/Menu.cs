using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodOrderAPIWebApp.Models
{
    public class Menu
    {
        public Menu()
        {
            MenuProducts = new List<MenuProduct>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Меню")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Інформація про меню")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Ціна")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Поле не може бути порожнім")]
        [Display(Name = "Кількість")]
        public int Quantity { get; set; }

        public virtual ICollection<MenuProduct> MenuProducts { get; set; }
    }
}
