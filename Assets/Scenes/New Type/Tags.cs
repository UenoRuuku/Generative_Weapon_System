using System;
using UnityEngine;

public class AttributeEnhanceTag : Tag
{
    public AttributeEnhanceTag(){
        Name = "Damage Bouns";
    }
    public float DamageMultiplier { get; set; }

    public override void Apply(Weapon weapon)
    {
        DamageMultiplier = UnityEngine.Random.Range(.0f,3.0f);
        Description = "The damage dealt by the weapon is enhanced by " + Convert.ToString(100+100*DamageMultiplier) + "%";
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
    public AttackModuleTag(){
        Name = "Burst Fire Mode";
    }
    public int BurstCount { get; set; }

    public override void Apply(Weapon weapon)
    {
        BurstCount = UnityEngine.Random.Range(2,5);
        if (weapon is RangedWeapon rangedWeapon)
        {
            // 修改武器的攻击模组，例如子弹3连发
            Description = "The weapon is switched to burst fire mode - " + Convert.ToString(BurstCount) + " bullets in a row.";
            rangedWeapon.Bullet.BurstCount *= BurstCount;
        }else{
            Description = "The tag only suits ranged weapons";
        }
    }
}

public class UselessTag : Tag
{

    public override void Apply(Weapon weapon)
    {

    }
}