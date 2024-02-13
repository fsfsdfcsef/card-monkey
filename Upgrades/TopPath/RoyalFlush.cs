using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace CardMonkey.Upgrades.TopPath
{
    public class RoyalFlush : ModUpgrade<CardMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 5;
        public override int Cost => 20000;
        public override int Priority => -2;

        public override string DisplayName => "皇家同花顺";

        public override string Description => "卡片伤害增加到10，11，12，13，14点";

        public override string Portrait => "CardMonkey-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.range += 10;
            tower.GetAttackModel().range += 10;
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.projectile.GetDamageModel().damage += 10;
            }
        }
    }
}