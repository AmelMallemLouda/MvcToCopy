using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeProject.Data
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingcartId { get; set; }
    }
}
