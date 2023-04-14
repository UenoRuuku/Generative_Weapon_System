using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    public string Name { get; set; }
    public int Level { get; set; }
    public List<Tag> Tags { get; set; }

    public Weapon()
    {
        Tags = new List<Tag>();
    }

    public abstract void Attack();
}

public abstract class Tag
{
    public string Name { get; set; }

    public abstract void Apply(Weapon weapon);
}

public class MeleeWeapon : Weapon
{
    public float Damage { get; set; }

    public override void Attack()
    {
        // 实现近战武器的攻击逻辑
    }
}

public class RangedWeapon : Weapon
{
    public float Damage { get; set; }
    public Bullet Bullet { get; set; }

    public override void Attack()
    {
        // 实现远程武器的攻击逻辑，例如发射子弹
    }
}
