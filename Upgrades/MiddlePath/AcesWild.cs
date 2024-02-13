using System.Linq;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using CardMonkey.Displays.Projectiles;

namespace CardMonkey.Upgrades.MiddlePath
{
    public class AcesWild : ModUpgrade<CardMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 3;
        public override int Cost => 1500;

        public override string DisplayName => "万能Ace";

        public override string Description =>
            "强力的Ace牌造成更多伤害，对陶瓷气球和强化气球伤害增加";

        public override string Portrait => "CardMonkey-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var projectile in tower.GetWeapons().Select(weaponModel => weaponModel.projectile))
            {
                projectile.GetDamageModel().damage++;
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Ceramic", "Ceramic",
                    1, 3, false, false));
                projectile.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Fortified", "Fortified",
                    1, 3, false, false));
                projectile.ApplyDisplay<WildAceCardDisplay>();
            }
        }
    }
}