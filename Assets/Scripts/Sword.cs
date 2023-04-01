using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using generative.data;

public class Sword:Weapon{

    public override void Start() {
        _name = Weapon_Name.sword;
        base.Start();
    }


    public override void Feature(){
        //do things that a sword should do like attacking... ..
    }
}