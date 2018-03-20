using System;
using DungeonsAndCodeWizards.Interfaces;
using DungeonsAndCodeWizards.Models.Bags;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Cleric : Character, IHealable
    {
        // 50 Base Health, 25 Base Armor, 40 Ability Points, and a Backpack as a bag
        private const double ClericBaseHealth = 50;
        private const double ClericAbilityPoints = 40;
        private const double ClericBaseArmor = 25;

        public Cleric(string name, Faction faction) 
            : base(name, ClericBaseHealth, ClericBaseArmor, ClericAbilityPoints, new Backpack(), faction)
        {
        }

        protected override double RestHealMultiplier => 0.5;

        public void Heal(Character character)
        {
            if (!this.IsAlive || !character.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            if (this.Faction != character.Faction)
            {
                throw new InvalidOperationException("Cannot heal enemy character!");
            }

            character.Health += this.AbilityPoints;
        }
    }
}
