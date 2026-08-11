using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MyFirstMod.Items
{
    // ModItem 是 tModLoader 里「自定义道具」的基类。
    // 我们新建一个 Starblade 类继承它，就等于造了一个新道具。
    public class Starblade : ModItem
    {
        // SetDefaults：设置道具的「数值属性」，比如伤害、出手速度、稀有度等。
        public override void SetDefaults()
        {
            Item.damage = 60;                       // 伤害值
            Item.DamageType = DamageClass.Melee;    // 伤害类型：近战(Melee)。远程用 Ranged，魔法用 Magic
            Item.width = 80;                        // 道具图标宽度(像素)，和贴图 Starblade.png 宽度一致
            Item.height = 80;                       // 道具图标高度(像素)，和贴图 Starblade.png 高度一致
            Item.useTime = 20;                      // 两次攻击之间的间隔(帧)，数字越小出手越快
            Item.useAnimation = 20;                 // 挥砍动画时长(帧)，通常和 useTime 保持一致
            Item.useStyle = ItemUseStyleID.Swing;   // 使用动作：挥砍(Swing)
            Item.knockBack = 6f;                    // 击退力，越大把敌人推得越远
            Item.value = Item.buyPrice(gold: 5);    // 售价：5 金币(gold)。也可写 silver/platinum
            Item.rare = ItemRarityID.Pink;          // 稀有度颜色：粉色(不错的装备)
            Item.UseSound = SoundID.Item1;          // 挥砍时播放的音效
            Item.autoReuse = true;                  // true = 按住鼠标左键可连续攻击
        }

        // AddRecipes：定义这个道具「怎么合成」。
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();                // 新建一个合成配方
            recipe.AddIngredient(ItemID.Starfury, 1);      // 需要 1 把「星怒」(Starfury)
            recipe.AddIngredient(ItemID.FallenStar, 20);   // 需要 20 个「落星」(FallenStar)
            recipe.AddTile(TileID.Anvils);                 // 需要在「铁砧/铅砧」旁边才能合成
            recipe.Register();                             // 注册配方(不写这行配方不生效)
        }
    }
}
