using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodOrderAPIWebApp.Models
{
    public class MenuProduct
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("ProductID")]
        public int ProductId { get; set; }

        [Column("MenuID")]
        public int MenuId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
