using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeProject.Models.ItemModels
{
   public  class ItemEdit
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        public double ItemPrice { get; set; }

        public string ItemCondition { get; set; }

        public string CategoryName { get; set; }
    }
}
