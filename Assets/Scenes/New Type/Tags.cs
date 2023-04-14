public class AttributeEnhanceTag : Tag
{
    public float DamageMultiplier { get; set; }

    public override void Apply(Weapon weapon)
    {
        // 修改武器的属性
        if (weapon is MeleeWeapon meleeWeapon)
        {
            meleeWeapon.Damage *= DamageMultiplier;
        }
        else if (weapon is RangedWeapon rangedWeapon)
        {
            rangedWeapon.Damage *= DamageMultiplier;
        }
    }
}

public class AttackModuleTag : Tag
{
    public int BurstCount { get; set; }

    public override void Apply(Weapon weapon)
    {
        if (weapon is RangedWeapon rangedWeapon)
        {
            // 修改武器的攻击模组，例如子弹3连发
            rangedWeapon.Bullet.BurstCount = BurstCount;
        }
    }
}