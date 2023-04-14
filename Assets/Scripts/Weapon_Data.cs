using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace generative.data
{
    public enum Weapon_Level
    {
        white = 0,
        green = 1,
        blue = 2,
        purple = 3,
        orange = 4,
    }

    public enum Tag_Name
    {
        LongRange,
    }

    public enum Weapon_Name
    {
        bow, ninjastar, sword,shotgun,axe,chainsaw,handgun,katana,
    }



    [System.Serializable]
    public class Weapon_Data
    {

        [SerializeField]
        public Weapon_Name name;
        [SerializeField]
        public Weapon_Level level;
        [SerializeField]
        string description;
        [SerializeField]
        int damage;
        [SerializeField]
        int range;
        [SerializeField]
        int attackSpeed;
        [SerializeField]
        public GameObject Texture3D;
    }

    public abstract class Tag_Data
    {
        public Tag_Name name;
        string description;
        public abstract void effect();
    }

}
