using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class UI : MonoBehaviour
{
    public    TMP_Text _name;
    public TMP_Text _damage;
    public TMP_Text _Tags;
    public TMP_Text _Level;
    public Image _image;
    public TMP_Text _description;

    public void updateUI(Weapon w){
        _name.text = w.Name;
        _description.text = Convert.ToString(w.description);
        _image.sprite = w.image;
        _damage.text = Convert.ToString(w.Damage);
        _Tags.text = "";
        _Level.text = "Level "+Convert.ToString(w.Level+1);
        if(w.Tags == null || w.Tags.Count == 0){
            _Tags.text = "level 1 weapons have no tags";
            return;
        }
        for (int i = 0 ; i < w.Tags.Count; i ++){
            _Tags.text += w.Tags[i].Name;
            _Tags.text += ":";
            _Tags.text += w.Tags[i].Description;
            _Tags.text += "\n";
        }
    }
}
