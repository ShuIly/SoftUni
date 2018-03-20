using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DungeonsAndCodeWizards.Models.Bags
{
    public abstract class Bag
    {
        private readonly List<Item> items;

        protected Bag(int capacity) 
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public int Capacity { get; protected set; }
        public ReadOnlyCollection<Item> Items => new ReadOnlyCollection<Item>(items);
        public int Load => this.items.Sum(i => i.Weight);

        public void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            int itemIndex = items.FindIndex(i => i.Name == name);

            if (itemIndex < 0)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }

            Item item = items[itemIndex];
            items.RemoveAt(itemIndex);
            return item;
        }
    }
}
