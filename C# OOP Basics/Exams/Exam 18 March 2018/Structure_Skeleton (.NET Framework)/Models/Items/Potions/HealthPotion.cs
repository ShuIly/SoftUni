using DungeonsAndCodeWizards.Models.Characters;

namespace DungeonsAndCodeWizards.Models.Items.Potions
{
    public class HealthPotion : Item
    {
        private const int HealthPotionWeight = 5;
        private const int HealthPotionHeal = 20;

        public HealthPotion()
            : base(HealthPotionWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health += HealthPotionHeal;
        }
    }
}
