using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeProject.Data
{
    public enum ClothingCategory { Women = 1, Man, KidsBabies }
    public class Clothing
    {
        [Key]
        public int ClothingId { get; set; }
        public ClothingCategory CategoryOfClothes { get; set; }

    }
}
