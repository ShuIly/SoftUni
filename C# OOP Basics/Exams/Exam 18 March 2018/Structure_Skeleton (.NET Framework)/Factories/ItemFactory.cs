using System;
using DungeonsAndCodeWizards.Models.Items;
using DungeonsAndCodeWizards.Models.Items.Kits;
using DungeonsAndCodeWizards.Models.Items.Potions;

namespace DungeonsAndCodeWizards.Factories
{
    public class ItemFactory
    {
        public Item CreateItem(string name)
        {
            Item item = null;

            switch (name)
            {
                case "HealthPotion":
                    item = new HealthPotion();
                    return item;
                case "PoisonPotion":
                    item = new PoisonPotion();
                    return item;
                case "ArmorRepairKit":
                    item = new ArmorRepairKit();
                    return item;
                default:
                    throw new ArgumentException($"Invalid item \"{name}\"!");
            }
        }
    }
}
