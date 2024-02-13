using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace CardMonkey.Upgrades.TopPath
{
    public class ThreeOfAKind : ModUpgrade<CardMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 2;
        public override int Cost => 700;

        public override string DisplayName => "三条";
        public override string Description => "一次扔出3张卡片";

        public override string Portrait => "CardMonkey-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 3, 0, 15, null, false, false);
        }
    }
}