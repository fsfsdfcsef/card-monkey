using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Simulation.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace CardMonkey.Upgrades.TopPath
{
    public class Pair : ModUpgrade<CardMonkey>
    {
        // public override string Portrait => "Don't need to override this, using the default of Pair-Portrait.png";
        // public override string Icon => "Don't need to override this, using the default of Pair-Icon.png";

        public override int Path => TOP;
        public override int Tier => 1;
        public override int Cost => 500;

        // public override string DisplayName => "Don't need to override this, the default turns it into 'Pair'"

        public override string DisplayName => "一对";

        public override string Description => "一次扔出2张卡片";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 2, 0, 10, null, false, false);
        }
    }
}