using UnityEngine;
using System.Collections;

public class AnimactionPlayer : MonoBehaviour {
   
   
	// Use this for initialization
	void Start () {
       
       
	}
	public void CicleAnimator(Animator Anim,string ParametroNome,int valor)// para parametros inteiro
    {
        Anim = GetComponent<Animator>();
        Anim.SetInteger(ParametroNome, valor);
    }
    public void CicleAnimator(Animator Anim, string ParametroNome, float valor)//para parametro float
    {
        Anim = GetComponent<Animator>();
        Anim.SetFloat(ParametroNome, valor);
    }
   public void CicleAnimator(Animator Anim, string ParametroNome, int valor,bool Ativado)
    {
        Anim = GetComponent<Animator>();
        int JumpHash = Animator.StringToHash(ParametroNome);
        if (Ativado)
        {
            Anim.SetTrigger(JumpHash);
        }
      
    }

	// Update is called once per frame
	void Update () {
       
     

	}
}
