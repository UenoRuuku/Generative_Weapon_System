using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using generative.data;
using System.Linq;


[CreateAssetMenu(fileName = "Weapon_Repository", menuName = "Generative_Repo/Weapon_Repository", order = 1)]
public class Weapon_Repo : ScriptableObject
{
    [SerializeField]
    public List<Weapon_Data> Weapons;

    public Weapon_Data GetWeaponByName(Weapon_Name w){
        return Weapons.Where(weapon => weapon.name == w).ToList<Weapon_Data>()[0] != null ? Weapons.Where(weapon => weapon.name == w).ToList<Weapon_Data>()[0]:null;
    }

}
