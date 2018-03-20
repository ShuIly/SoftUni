using System;
using DungeonsAndCodeWizards.Models.Characters;

namespace DungeonsAndCodeWizards.Models.Items
{
    public abstract class Item
    {
        public int Weight { get; }
        public string Name { get; }

        protected Item(int weight)
        {
            this.Weight = weight;
            this.Name = this.GetType().Name;
        }

        public virtual void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new  InvalidOperationException("Must be alive to perform this action!");
            }
        }
    }
}
