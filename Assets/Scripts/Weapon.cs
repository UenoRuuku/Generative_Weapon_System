using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using generative.data;




public class Weapon:MonoBehaviour{
    [SerializeField]
    public Weapon_Name _name;
    public Weapon_Data _data;
    public Tags_Repo t_repo;

    public List<Tag_Data> tags;
    int maxTags = 0;

    public Weapon_Repo repo;

    public virtual void Start() {
        _data = repo.GetWeaponByName(_name);
        Weapon_Level l = (Weapon_Level)Random.Range(0,5);
        _data.level = l;
        tags = new List<Tag_Data>();
        maxTags = (int)l;
    }

    public virtual void Feature(){}

    public virtual void AddTags(){

    }

}