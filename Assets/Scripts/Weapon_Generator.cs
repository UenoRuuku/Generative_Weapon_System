using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using generative.data;

public class Weapon_Generator : MonoBehaviour {
    public Tag_Generator t;

    public void Start(){


    }

    public Weapon GenerateWeapon(Vector3 pos){
        // should be 8 if all name and classes have been finished
        Weapon_Name w = (Weapon_Name)Random.Range(0,2);//(0,8)
        Weapon rw = null;
        switch (w){
            case Weapon_Name.sword:
                rw = new Sword();
                InitiateAWeaponBasedOnPos(rw,pos);
                break;
            default:
                break;
        }
        return rw;
    }

    public void InitiateAWeaponBasedOnPos(Weapon w, Vector3 pos){

        GameObject a = Instantiate(w._data.Texture3D,pos, new Quaternion(0,0,0,0));
        a.AddComponent(w.GetType());
        
    }
}