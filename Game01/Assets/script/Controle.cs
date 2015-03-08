using UnityEngine;
using System.Collections;

public class Controle : MonoBehaviour {
    public Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Contro(player);
	}
   
    void Contro(Transform Obj3d)
    {
        // para evitar Erro Caso n possua o Componente no objeto
        if (Obj3d.GetComponent<PlayerAtributo>())
        {
            if (Input.GetKey(KeyCode.A))
            { 
            // anda Tras
                Movimento.Move(Obj3d, false);
            }
            if (Input.GetKey(KeyCode.D))
            {
                // anda Frente
                Movimento.Move(Obj3d, true);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                // pula
            }
            if (Input.GetMouseButton(0))
            { 
                // atira
            }
        




        }

    }
}
