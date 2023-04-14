using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using generative.data;
public class Axe : Weapon
{
    // Start is called before the first frame update
    public override void Start()
    {
        _name = Weapon_Name.axe;
        base.Start();
    }


    public override void Feature()
    {
        //do things that a sword should do like attacking... ..
    }
}
