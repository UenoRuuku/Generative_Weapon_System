using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using generative.data;

public class Tag : MonoBehaviour{
    public Tag_Name name;
    Tag_Data _data;
    public Tags_Repo repo;

    public virtual void Start(){
        _data = repo.GetTagByName(name);
    }

    public virtual void effect(){
        // the effect of the tags .. ..  how it affects ...
    }
}
