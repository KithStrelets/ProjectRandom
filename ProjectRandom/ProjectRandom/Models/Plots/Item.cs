using ProjectRandom.Models.Constants;
using ProjectRandom.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models.Plots
{
    // Maybe not abstract???
    public class Item : IEquipable, IReusable, IRandomizer<Item>
    {
        string itemName;

        // ToDo: Change object --> image type
        object itemPicture;

        int itemAmount;

        ItemType itemType;

        //public abstract bool IsEquipment { get; }
        public bool IsEquipment { get; }

        //public abstract bool IsReusable { get; }
        public bool IsReusable { get; }

        //public abstract Item GetRandom();
        public Item GetRandom() => new Item();

        public string ItemName { get => itemName; set => itemName = value; }

        public object ItemPicture => itemPicture;

        // ToDo: Make disposing of this Item if amount is less than 1
        public int ItemAmount { get => itemAmount; set => itemAmount = value; }

        public ItemType ItemType { get => itemType; set => itemType = value; }

        //public static Item GetRandomItem(Plot plot, IDatabaseConnection db)
        //{
        //    var randomItem = db.GetRandomItem(plot);
        //    return new Item();
        //}
    }
}
