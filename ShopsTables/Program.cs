using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsTables
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new ShopsContext())
            {
                  // context.ShopItems.ToList();
                //Shop shop = new Shop() { Address = "Tyan/15", Id = 2, Name = "Meater" };
                //Item item = new Item() { Id = 2, Name = "Meat", Price = 350 };
                //Item item2 = new Item() { Id = 3, Name = "Milk", Price = 250 };
                //Item item3 = new Item() { Id = 4, Name = "Cheese", Price = 900 };
                //Item item4 = new Item() { Id = 5, Name = "ChokoBar", Price = 100 };
                //ShopItems shopItem = new ShopItems() { Id = 3, Item_Id = 1, Shop_Id = 1,Count=1000 };
                //ShopItems shopItem2 = new ShopItems() { Id = 4, Item_Id = 4, Shop_Id = 1, Count = 500 };
                //ShopItems shopItem3 = new ShopItems() { Id = 5, Item_Id = 3, Shop_Id = 2, Count = 200 };
                //ShopItems shopItem4 = new ShopItems() { Id = 6, Item_Id = 1, Shop_Id = 2, Count = 1500 };
                ////context.Items.Add(item);
                ////context.Items.Add(item2);
                ////context.Items.Add(item3);
                ////context.Items.Add(item4);
                ////context.Shops.Add(shop);
                //context.ShopItems.Add(shopItem);
                //context.ShopItems.Add(shopItem2);
                //context.ShopItems.Add(shopItem3);
                //context.ShopItems.Add(shopItem4);

                var query = from a in context.ShopItems
                            where (a.Shop.Address) == "Tyan/15"
                            where a.Item.Id==a.Item_Id
                            select new { a.Count, a.Item.Name };
               var adf =query.ToList();


                
                context.SaveChanges();
                

            }

           
            

            
        }
    }
}
