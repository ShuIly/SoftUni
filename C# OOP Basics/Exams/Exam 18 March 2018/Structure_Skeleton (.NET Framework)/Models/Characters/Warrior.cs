using System;
using DungeonsAndCodeWizards.Interfaces;
using DungeonsAndCodeWizards.Models.Bags;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Warrior : Character, IAttackable
    {
        // 100 Base Health, 50 Base Armor, 40 Ability Points, and a Satchel as a bag
        private const double WarriorBaseHealth = 100;
        private const double WarriorBaseArmor = 50;
        private const double WarriorAbilityPoints = 40;

        public Warrior(string name, Faction faction) 
            : base(name, WarriorBaseHealth, WarriorBaseArmor, WarriorAbilityPoints, new Satchel(), faction)
        {
        }

        public void Attack(Character character)
        {
            if (!this.IsAlive || !character.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            if (this == character)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }

            if (this.Faction == character.Faction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
            }

            character.TakeDamage(this.AbilityPoints);
        }
    }
}
