using DungeonsAndCodeWizards.Models.Characters;
using DungeonsAndCodeWizards.Models.Items;

namespace DungeonsAndCodeWizards.Models.Items.Potions
{
    public class PoisonPotion : Item
    {
        private const int PoisonPotionWeight = 5;
        private const int PoisonPotionDamage = 20;
        public PoisonPotion() 
            : base(PoisonPotionWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health -= PoisonPotionDamage;
        }
    }
}
