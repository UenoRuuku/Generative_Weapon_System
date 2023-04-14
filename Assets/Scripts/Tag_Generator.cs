using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using generative.data;

public class Tag_Generator : MonoBehaviour {
    public Tag GenerateTag(){
        Tag_Name t = (Tag_Name)Random.Range(0,8);//(0,8)
        Tag rt = null;
        switch (t){
            case Tag_Name.LongRange:
                rt = new LongRange();
                break;
            default:
                break;
        }
        return rt;
    }
}