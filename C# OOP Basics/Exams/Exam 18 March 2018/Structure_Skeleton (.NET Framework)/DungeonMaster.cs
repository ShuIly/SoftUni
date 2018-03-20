using System;
using System.Collections.Generic;
using System.Linq;
using DungeonsAndCodeWizards.Factories;
using DungeonsAndCodeWizards.Interfaces;
using DungeonsAndCodeWizards.Models.Characters;
using DungeonsAndCodeWizards.Models.Items;

namespace DungeonsAndCodeWizards
{
    public class DungeonMaster
    {
        private readonly Dictionary<string, Character> party;
        private readonly Stack<Item> itemPool;
        private readonly ItemFactory itemFactory;
        private readonly CharacterFactory characterFactory;
        private int lastSurvivorRounds;

        public DungeonMaster()
        {
            this.party = new Dictionary<string, Character>();
            this.itemPool = new Stack<Item>();
            itemFactory = new ItemFactory();
            characterFactory = new CharacterFactory();
        }

        public string JoinParty(string[] args)
        {
            string faction = args[0];
            string charType = args[1];
            string name = args[2];

            Character character = characterFactory.CreateCharacter(faction, charType, name);
            this.party.Add(name, character);

            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemName = args[0];
            Item item = itemFactory.CreateItem(itemName);

            itemPool.Push(item);

            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];

            Validator.ValidateCharacter(characterName, party);
            Character character = party[characterName];
            if (!character.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            if (itemPool.Count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }

            Item item = itemPool.Pop();
            party[characterName].ReceiveItem(item);

            return $"{characterName} picked up {item.Name}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];

            Validator.ValidateCharacter(characterName, party);
            Character character = party[characterName];
            if (!character.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            Item item = character.Bag.GetItem(itemName);
            character.UseItem(item);

            return $"{character.Name} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[0];
            string recieverName = args[1];
            string itemName = args[2];

            Validator.ValidateCharacter(giverName, party);
            Validator.ValidateCharacter(recieverName, party);

            Character giver = party[giverName];
            Character reciever = party[recieverName];
            if (!giver.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");
            if (!reciever.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");
            Item item = giver.Bag.GetItem(itemName);

            giver.UseItemOn(item, reciever);

            return $"{giverName} used {itemName} on {recieverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            string giverName = args[0];
            string recieverName = args[1];
            string itemName = args[2];

            Validator.ValidateCharacter(giverName, party);
            Validator.ValidateCharacter(recieverName, party);

            Character giver = party[giverName];
            Character reciever = party[recieverName];
            if (!giver.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");
            if (!reciever.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            Item item = giver.Bag.GetItem(itemName);

            reciever.GiveCharacterItem(item, reciever);

            return $"{giverName} gave {recieverName} {itemName}.";
        }

        public string GetStats()
        {
            return String.Join(Environment.NewLine, party.Values
                    .OrderByDescending(c => c.IsAlive)
                    .ThenByDescending(c => c.Health));
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string recieverName = args[1];

            Validator.ValidateCharacter(attackerName, party);
            Validator.ValidateCharacter(recieverName, party);


            Character attacker = party[attackerName];
            if (!(attacker is IAttackable attackerInt))
            {
                throw new ArgumentException($"{attackerName} cannot attack!");
            }

            Character reciever = party[recieverName];

            if (!attacker.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");
            if (!reciever.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            attackerInt.Attack(reciever);

            string result = $"{attackerName} attacks {recieverName} for {attacker.AbilityPoints} hit points! {recieverName} has {reciever.Health}/{reciever.BaseHealth} HP and {reciever.Armor}/{reciever.BaseArmor} AP left!";

            if (!reciever.IsAlive)
            {
                result += Environment.NewLine + $"{recieverName} is dead!";
            }

            return result;
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string recieverName = args[1];

            Validator.ValidateCharacter(healerName, party);
            Validator.ValidateCharacter(recieverName, party);

            Character healer = party[healerName];
            if (!(healer is IHealable healerInt))
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }

            Character reciever = party[recieverName];

            if (!healer.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");
            if (!reciever.IsAlive) throw new InvalidOperationException("Must be alive to perform this action!");

            healerInt.Heal(reciever);

            return $"{healer.Name} heals {recieverName} for {healer.AbilityPoints}! {recieverName} has {reciever.Health} health now!";
        }

        public string EndTurn()
        {
            int numCharacters = 0;
            List<string> resultList = new List<string>();
            foreach (Character character in party.Values
                .Where(p => p.IsAlive))
            {
                double healthBeforeRest = character.Health;
                character.Rest();
                resultList.Add($"{character.Name} rests ({healthBeforeRest} => {character.Health})");

                numCharacters++;
            }

            if (numCharacters <= 1) lastSurvivorRounds++;

            return String.Join(Environment.NewLine, resultList);
        }

        public bool IsGameOver()
        {
            return lastSurvivorRounds == 2;
        }
    }
}
