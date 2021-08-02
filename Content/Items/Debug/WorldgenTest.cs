﻿using Microsoft.Xna.Framework;
using Rejuvena.Assets;
using Rejuvena.Content.Biomes;
using Rejuvena.Content.Players.AccessoryHandlers;
using Terraria;

namespace Rejuvena.Content.Items.Debug
{
    /// <summary>
    ///     Classless accessory that allows for reversing knock-back inflicted on NPCs.
    /// </summary>
    [FallbackAsset(FallbackAssetType.Tome)]
    public class WorldgenTest : RejuvenaItem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();

            Item.Size = new Vector2(28f, 32f);
            Item.useStyle = 1;
            Item.useAnimation = 1;
            Item.useTime = 1;
            Item.autoReuse = false;
        }

        public override bool? UseItem(Player player)
        {
            SkyTowerGeneration.GenTower(new Point((int)Main.MouseWorld.X / 16, (int)Main.MouseWorld.Y / 16));

            return base.UseItem(player);
        }
    }
}