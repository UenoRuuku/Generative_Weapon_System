using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]
    public string Name;
    [SerializeField]
    public float Damage; //{ get; set; }
    [SerializeField]
    public int Level;
    [SerializeField]
    public Sprite image;
    [SerializeField]
    public string description;
    public List<Tag> Tags { get; set; }

    public void Start()
    {
        if (Tags == null)
        {
            Tags = new List<Tag>();
        }
    }

    public abstract void Attack();

    public void AddTag(Tag t)
    {
        if (Tags == null)
        {
            Tags = new List<Tag>();
        }
        Tags.Add(t);
    }

    public int SetRarity(int r)
    {
        return Level = r;
    }
}

public abstract class Tag
{
    public string Name { get; set; }
    public string Description { get; set; }

    public abstract void Apply(Weapon weapon);
}

public class MeleeWeapon : Weapon
{

    public override void Attack()
    {
        // 实现近战武器的攻击逻辑
    }
}

public class RangedWeapon : Weapon
{


    [SerializeField]
    public Bullet Bullet; //{ get; set; }

    public override void Attack()
    {
        // 实现远程武器的攻击逻辑，例如发射子弹
    }
}
