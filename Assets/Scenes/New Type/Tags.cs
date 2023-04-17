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

public class BloodDrinker : Tag
{
    public BloodDrinker()
    {
        Name = "BloodDrinker";
    }
    public override void Apply(Weapon weapon)
    {

        Description = "Each attack has a 30% chance of life steal.";
    }

}

public class PowerOfLightning : Tag
{
    public PowerOfLightning()
    {
        Name = "Power of Lightning";
    }
    public override void Apply(Weapon weapon)
    {

        Description = "Each attack has a 15% chance of triggering chain lightning, which deals 30 damage.";
    }

}

public class ThreeRing : Tag
{
    public ThreeRing()
    {
        Name = "Dragon Breath";
    }
    public override void Apply(Weapon weapon)
    {

        Description = "Each 3 times attacks will deal one fire attack. It will allow weapon to deal additional 50 fire damage.";
    }

}

public class FinalSpark: Tag
{
    public FinalSpark()
    {
        Name = "Final Spark";
    }
    public override void Apply(Weapon weapon)
    {

        Description = "Each attack has a 20% chance of causing a penetrating attack.";
    }

}

public class Damnation : Tag
{
    public Damnation()
    {
        Name = "A curse from the Grim Reaper";
    }
    public override void Apply(Weapon weapon)
    {

        Description = "There is a 30% chance that a soul will appear after killing an enemy unit, and each soul can help restore 1 life point.";
    }

}

public class TwinFang: Tag
{
    public TwinFang()
    {
        Name = "Medea's Posion";
    }
    public override void Apply(Weapon weapon)
    {

        Description = "Each attack has a 10% chance of triggering posioned, which deals 5 damage each second.";
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