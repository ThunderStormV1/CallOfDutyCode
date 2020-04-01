using Terraria.ID;
using Terraria.ModLoader;

namespace CallOfDuty.Items.Weapons
{
	public class Raygun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Raygun"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'Works well with PhDFlopper'");
		}

		public override void SetDefaults() 
		{
			item.damage = 88;
			item.magic = true;
			item.width = 24;
			item.height = 18;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 10000;
			item.rare = 8;
			item.UseSound = SoundID.Item12;
			item.autoReuse = true;
			item.mana = 8;
			item.shoot = mod.ProjectileType("RaygunP");
			item.shootSpeed = 16f;
			item.noMelee = true;
			
        }

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}