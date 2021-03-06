using RedBadgeMVCProject.Data;
using RedBadgeProject.Data;
using RedBadgeProject.Models;
using RedBadgeProject.Models.ItemModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeProject.Service
{
    public class ItemService
    {
        private readonly Guid _userId;

        public ItemService(Guid userId)
        {
            _userId = userId;
        }

        //Create an instance of Item
        public bool CreateItem(ItemCreate item)
        {
            var entity = new Item()
            {
                OwnerId = _userId, //We want the user who creates the note to be the user who is logged in
                ItemName = item.ItemName,
                ItemDescription = item.ItemDescription,
                ItemPrice = item.ItemPrice,
                ItemCondition = item.ItemCondition,
                //CategoryName = item.CategoryName
            };
            using (var ctx = new ApplicationDbContext())// Access database
            {
                ctx.Items.Add(entity);// access items Table and add items
                return ctx.SaveChanges() == 1;
            }
        }

        //See all the Items 
        public IEnumerable<ItemList> GetAllItems()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Items.Select(e => new ItemList
                {
                    ItemName = e.ItemName,
                    ItemPrice = e.ItemPrice
                });

                return query.ToArray();
            }
        }

        //See Details

        public ItemDetails GetItemById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Items.Single(e => e.ItemId == id);

                return
                    new ItemDetails
                    {
                        ItemName = entity.ItemName,
                        ItemDescription = entity.ItemDescription,
                        ItemPrice = entity.ItemPrice,
                        ItemCondition = entity.ItemCondition,
                        //CategoryName = entity.CategoryName
                    };
            }
        }


        public bool UpdateItem(ItemEdit item)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Items.Single(e => e.ItemId == item.ItemId && e.OwnerId == _userId);
                entity.ItemName = item.ItemName;
                entity.ItemDescription = item.ItemDescription;
                entity.ItemPrice = item.ItemPrice;
                entity.ItemCondition = item.ItemCondition;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteItem(int ItemId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Items.Single(e => e.ItemId == ItemId && e.OwnerId == _userId);

                     ctx.Items.Remove(entity);

                return ctx.SaveChanges() == 1;
            };
        }
}   } 
