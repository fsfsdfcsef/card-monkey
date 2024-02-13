using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;

namespace CardMonkey.Upgrades
{
    public class GodKingOfSpades : ModParagonUpgrade<CardMonkey>
    {
        public override int Cost => 400000;
        public override string Description => "有时候必须将命运掌握在手中...";
        public override string DisplayName => "黑桃之王";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            // Using 555 mode so not much has to be done here if you don't want to
        }
    }
}