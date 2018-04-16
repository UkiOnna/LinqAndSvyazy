using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsTables
{
  public  class ShopItems
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Shop")]
        public int Shop_Id { get; set; }
        public Shop Shop { get; set; }
        [ForeignKey("Item")]
        public int Item_Id { get; set; }
        public Item Item { get; set; }
        public int Count { get; set; }
    }
}
