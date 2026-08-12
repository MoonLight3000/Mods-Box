using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MyFirstMod.Content.Projectiles
{
    public class StarbladeProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 16;             // 碰撞宽
            Projectile.height = 16;            // 碰撞高
            Projectile.friendly = true;        // 对敌人造成伤害
            Projectile.DamageType = DamageClass.Melee;
            Projectile.penetrate = -1;         // 穿透 3 个敌人（-1 表示无限）
            Projectile.timeLeft = 90;          // 存在 90 帧（约 1.5 秒）后消失
            Projectile.light = 0.5f;           // 照亮周围
            Projectile.ignoreWater = true;     // 不受水影响
            Projectile.tileCollide = true;     // 穿墙飞行（true 则会撞墙消失）
            Projectile.aiStyle = 0;            // 0 = 完全自定义，由 AI() 控制
        }

        public override void AI()
        {
            Projectile.ai[0] += 0.75f;     // ai[0] 是这发弹幕自带的"记事本"，跨帧保留
            Projectile.rotation = Projectile.velocity.ToRotation() + Projectile.ai[0];
        }
    }
}