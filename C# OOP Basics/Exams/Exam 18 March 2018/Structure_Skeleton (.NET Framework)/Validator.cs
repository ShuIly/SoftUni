using System;
using System.Collections.Generic;
using DungeonsAndCodeWizards.Models.Characters;

namespace DungeonsAndCodeWizards
{
    public static class Validator
    {
        public static void ValidateCharacter(string name, Dictionary<string, Character> party)
        {
            if (!party.ContainsKey(name))
            {
                throw new ArgumentException($"Character {name} not found!");
            }
        }
    }
}
