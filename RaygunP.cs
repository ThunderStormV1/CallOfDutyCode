using Terraria.ID;
using Terraria.ModLoader;
 
namespace CallOfDuty.Projectiles
{
    public class RaygunP : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 48;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.extraUpdates = 100;
            projectile.timeLeft = 200;
            projectile.penetrate = -1;
        }
     
    }
}