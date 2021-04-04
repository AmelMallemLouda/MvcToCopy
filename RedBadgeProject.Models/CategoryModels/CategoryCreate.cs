using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeProject.Models.CategoryModels
{
    public class CategoryCreate
    {
        [Required]
        public string Clothing { get; set; }

        [Required]
        public string HomeKitchen { get; set; }

        [Required]
        public string BeautyHealth { get; set; }
    }
}
