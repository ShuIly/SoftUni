using System;
using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Items;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public abstract class Character
    {
        private string name;
        private double health;
        private double armor;

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.name = name;
            this.BaseHealth = health;
            this.health = health;
            this.BaseArmor = armor;
            this.armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.IsAlive = true;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }

                this.name = value;
            }
        }

        public double BaseHealth { get; }

        public double Health
        {
            get => this.health;
            set
            {
                if (value > this.BaseHealth)
                {
                    this.health = this.BaseHealth;
                    return;
                }

                if (value < 0)
                {
                    this.health = 0;
                    this.IsAlive = false;
                    return;
                }

                this.health = value;
            }
        }

        public double BaseArmor { get; }

        public double Armor
        {
            get => this.armor;
            set
            {
                if (value > this.BaseArmor)
                {
                    this.armor = this.BaseArmor;
                    return;
                }

                if (value < 0)
                {
                    this.armor = 0;
                    return;
                }

                this.armor = value;
            }
        }

        public double AbilityPoints { get; }
        public Bag Bag { get; }
        public Faction Faction { get; }
        public bool IsAlive { get; protected set; }

        protected virtual double RestHealMultiplier => 0.2;


        public void TakeDamage(double hitPoints)
        {
            if (!this.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            double leftHitPoints = hitPoints - this.Armor;
            this.Armor -= hitPoints;

            if (leftHitPoints > 0)
            {
                this.Health -= leftHitPoints;
            }
        }

        public void Rest()
        {
            if (!this.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            this.Health += this.BaseHealth * this.RestHealMultiplier;
        }

        public void UseItem(Item item)
        {
            if (!this.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            item.AffectCharacter(this);
        }

        public void UseItemOn(Item item, Character character)
        {
            if (!this.IsAlive || !character.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            item.AffectCharacter(character);
        }

        public void ReceiveItem(Item item)
        {
            if (!this.IsAlive) return;

            this.Bag.AddItem(item);
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            if (!this.IsAlive || !character.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            character.ReceiveItem(item);
        }

        public override string ToString()
        {
            string status = this.IsAlive ? "Alive" : "Dead";
            return $"{this.Name} - HP: {this.health}/{this.BaseHealth}, AP: {this.Armor}/{this.BaseArmor}, Status: {status}";
        }
    }
}
