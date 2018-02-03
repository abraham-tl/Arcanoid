using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_player : MonoBehaviour {
	public float velocidad;

    public bool poder;

    Movimiento_pelota mov_pelota;


	float limite_pos;
	float limite_neg;
	// Use this for initialization
	void Start () {
		limite_pos = 2;
		limite_neg = -2;
	}

	// Update is called once per frame
	void Update () {
        
		float trasladar = Input.GetAxis ("Horizontal") * velocidad;
		trasladar *= Time.deltaTime;
		if (trasladar > 0 && transform.position.x <= limite_pos) {
			transform.Translate (Vector2.right *trasladar);
		} 
		if (trasladar < 0 && transform.position.x >= limite_neg) {
			transform.Translate (Vector2.left * (trasladar*-1));
		}
       
				
	}

    void poder_pelota()
    {

    }
    void pode_player()
    {

    }

    public void poder_lento()
    {
        mov_pelota .
    }

    void OnTriggerEnter2D(Collider2D contacto)
    {
        if (contacto.gameObject.tag == "Poder")
        {
            poder_pelota();
        }
    }
}


