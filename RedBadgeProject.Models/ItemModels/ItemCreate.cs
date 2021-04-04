using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeProject.Models
{
    public class ItemCreate
    {
        [Required]
        public string ItemName { get; set; }

        [Required]
        public string ItemDescription { get; set; }

        [Required]
        public double ItemPrice { get; set; }

        [Required]
        public string ItemCondition { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
