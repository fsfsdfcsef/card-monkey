using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Simulation.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace CardMonkey.Upgrades.MiddlePath
{
    public class CutTheDeck : ModUpgrade<CardMonkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 1;
        public override int Cost => 400;

        public override string DisplayName => "切牌";
        public override string Description => "提升卡片穿透";

        public override string Portrait => "CardMonkey-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var weaponModel in tower.GetWeapons())
            {
                if (tower.tier == 5)
                {
                    weaponModel.projectile.pierce += 30;
                }
                else
                {
                    weaponModel.projectile.pierce += 3;
                }
            }
        }
    }
}