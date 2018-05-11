using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRandom.Models
{
    abstract class Item : IEquipable, IReusable
    {
        string itemName;

        // ToDo: Change object --> image type
        object itemPicture;

        int itemAmount;

        ItemType itemType;

        public abstract bool IsEquipment { get; }

        public abstract bool IsReusable { get; }
    }
}
