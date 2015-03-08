using UnityEngine;
using System.Collections;

public class PlayerAtributo : MonoBehaviour {
    static public float _Gravid;
    public float Gravid
    {
        get { return _Gravid; }
        set { _Gravid = Gravid; }
    }
    
    
    static public float _Speed;
    public float Speed;
 
    public int Vida;
    public Transform Obj3d;
    static public string _Tag;
    public string Tag
    {
        get { return _Tag; }
        set { _Tag = Tag; }
    }


    void Awake()
    {
        Obj3d = gameObject.transform;
        ManipulaTag(transform, Tag);
        
    }
    void ManipulaTag (Transform Obj ,string _Tags)
    { Obj.transform.tag=_Tags; }
    
    
    

}
