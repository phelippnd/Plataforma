using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
       
        
	}
	
	// Update is called once per frame
    static public void Pulo(Transform Obj3d, bool Ativa,float TempJump)
    {
        float ForceGravid = Obj3d.GetComponent<PlayerAtributo>().Gravid;
        bool IsGravid=false;
        if (IsGravid )
        {
            Obj3d.Translate(0,- ForceGravid, 0);
        }

        if (Ativa)
        {
            Obj3d.Translate(0, ForceGravid, 0);
            float cont = Time.deltaTime;
            cont += Time.deltaTime;

        }
        if (!Ativa)
        { IsGravid = true; }


    }
    static public void Move(Transform Obj3d, bool Dir)//caso seja true Move Direita caso seja false Move Esquerda
    {
         
        Vector3 move=new Vector3( Obj3d.GetComponent<PlayerAtributo>().Speed*Time.deltaTime, Obj3d.GetComponent<PlayerAtributo>().Gravid*Time.deltaTime,0);
         
        if (Dir)
        {//direita
            Obj3d.Translate(move);
           
           
        }
        if (!Dir)
        {//esquerda
          
            Obj3d.Translate(-move.x,move.y,move.z);
        }
        
        
    }

}
