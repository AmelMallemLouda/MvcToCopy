using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeProject.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Clothing { get; set; }
        public virtual Clothing Clothes { get; set; }
        [Required]
        public string HomeKitchen { get; set; }
        public virtual HomeKitchen HomeAndKitchen { get; set; }

        public string BeautyHealth { get; set; }
        public virtual BeautyHealth BeautyAndHealth { get; set; }
        public virtual List<Item> Items { get; set; } = new List<Item>();

    }
}
