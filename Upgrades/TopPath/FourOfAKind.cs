﻿using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace CardMonkey.Upgrades.TopPath
{
    public class FourOfAKind : ModUpgrade<CardMonkey>
    {
        public override int Path => TOP;
        public override int Tier => 3;
        public override int Cost => 1000;

        public override string DisplayName => "四条";
        public override string Description => "一次扔出4张卡片";

        public override string Portrait => "CardMonkey-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 4, 0, 20, null, false, false);
        }
    }
}