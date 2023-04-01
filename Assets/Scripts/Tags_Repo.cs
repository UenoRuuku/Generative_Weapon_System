using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using generative.data;
using System.Linq;


[CreateAssetMenu(fileName = "Tag_Repository", menuName = "Generative_Repo/Tag_Repository", order = 1)]
public class Tags_Repo : ScriptableObject
{
    [SerializeField]
    public List<Tag_Data> Tags;

    public Tag_Data GetTagByName(Tag_Name w){
        return Tags.Where(Tag => Tag.name == w).ToList<Tag_Data>()[0] != null ? Tags.Where(Tag => Tag.name == w).ToList<Tag_Data>()[0]:null;
    }

}