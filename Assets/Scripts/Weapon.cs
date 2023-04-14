using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using generative.data;




public class Weapon:MonoBehaviour{
    [SerializeField]
    public Weapon_Name _name;
    public Weapon_Data _data;

    public List<Tag_Data> tags;
    int maxTags = 0;
    Weapon_Level level = 0;

    public Weapon_Repo repo;

    public virtual void Start() {
        Weapon_Level l = (Weapon_Level)Random.Range(0,5);
        level = l;
        _data.level = level;
        tags = new List<Tag_Data>();
        maxTags = (int)l;
    }

    public void InitiateData(Weapon_Data d) {
        _data = d;
        _data.level = level;
    }

    public virtual void Feature(){}

    public virtual void AddTags(){

    }

}