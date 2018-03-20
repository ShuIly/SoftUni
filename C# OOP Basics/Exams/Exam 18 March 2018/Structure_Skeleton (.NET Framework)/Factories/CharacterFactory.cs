using System;
using DungeonsAndCodeWizards.Models.Characters;

namespace DungeonsAndCodeWizards.Factories
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string faction, string type, string name)
        {
            if (!Enum.TryParse(faction, out Faction resFaction))
            {
                throw new ArgumentException($"Invalid faction \"{faction}\"!");
            }

            Character character = null;
            switch (type)
            {
                case "Warrior":
                    character = new Warrior(name, resFaction);
                    return character;
                case "Cleric":
                    character =  new Cleric(name, resFaction);
                    return character;
                default:
                    throw new ArgumentException($"Invalid character type \"{type}\"!");
            }
        }
    }
}
