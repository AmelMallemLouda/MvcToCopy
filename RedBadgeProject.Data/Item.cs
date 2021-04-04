using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeProject.Data
{
   public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public Guid OwnerId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot be greater than 50 characters")]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 characters")]
        public string ItemName { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Description cannot be less than 10")]
        public string ItemDescription { get; set; }

        [Required]
        public double ItemPrice { get; set; }

        [Required]
        public string ItemCondition { get; set; }

        //[ForeignKey(nameof(Category))]
        //public string CategoryName { get; set; }
        //public virtual Category Category { get; set; }
    }
}
