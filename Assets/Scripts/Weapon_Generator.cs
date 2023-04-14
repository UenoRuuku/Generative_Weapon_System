using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using generative.data;
using UnityEngine.UI;
using TMPro;

public class Weapon_Generator : MonoBehaviour {
    public Tag_Generator t;

    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Weapon_Repo repo;
  

    public void Start(){

        GenerateWeapon(pos1.position);
        GenerateWeapon(pos2.position);
        GenerateWeapon(pos3.position);
    }

    public Weapon GenerateWeapon(Vector3 pos){
        // should be 8 if all name and classes have been finished
        Weapon_Name w = (Weapon_Name)Random.Range(0,8);//(0,8)
        Weapon rw = null;
        Weapon_Data _data = repo.GetWeaponByName(w);
        switch (w){
            case Weapon_Name.sword:
                rw = new Sword();
                InitiateAWeaponBasedOnPos(_data,rw,pos);
                break;
            case Weapon_Name.axe:
                rw = new Axe();
                InitiateAWeaponBasedOnPos(_data,rw, pos);
                break;
            case Weapon_Name.bow:
                rw = new Bow();
                InitiateAWeaponBasedOnPos(_data, rw, pos);
                break;
            case Weapon_Name.chainsaw:
                rw = new Chainsaw();
                InitiateAWeaponBasedOnPos(_data, rw, pos);
                break;
            case Weapon_Name.handgun:
                rw = new Handgun();
                InitiateAWeaponBasedOnPos(_data, rw, pos);
                break;
            case Weapon_Name.katana:
                rw = new Katana();
                InitiateAWeaponBasedOnPos(_data, rw, pos);
                break;
            case Weapon_Name.ninjastar:
                rw = new Ninjastar();
                InitiateAWeaponBasedOnPos(_data, rw, pos);
                break;
            case Weapon_Name.shotgun:
                rw = new Shotgun();
                InitiateAWeaponBasedOnPos(_data, rw, pos);
                break;
            default:
                break;
        }
        return rw;
    }

    public void InitiateAWeaponBasedOnPos(Weapon_Data d, Weapon w, Vector3 pos){

        GameObject a = Instantiate(d.Texture3D,pos, new Quaternion(0,0,0,0));
        a.AddComponent(w.GetType());
        a.GetComponent<Weapon>().InitiateData(d);
        //weapon_name.SetText(a.name);
        //color_level.SetText();
        
    }
}