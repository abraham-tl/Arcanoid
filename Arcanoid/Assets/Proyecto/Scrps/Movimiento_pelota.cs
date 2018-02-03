using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Movimiento_pelota : MonoBehaviour {
	public bool ver;
	public bool hor;
	public bool inicio;
	public bool juego;
    public bool gana_vida;

    public float limite_ver;
	public float limite_ver_n;
	public float velocidad;

	public float limite_hor;
	public float limite_hor_n;
	public Transform   pos_inicial;

	public int vida ;
	
    int aux_index;
	public Text text_vida;
	public Text text_puntos;
	public Text text_terminado;

	public GameObject player;
    //public GameObject poder;
    public GameObject pelota2;

    public Transform power;

    Movimiento_player mov_player;
	// Use this for initialization
	void Start () {
				

        text_vida.text = Global.vida .ToString();
        text_puntos.text = Global.puntos.ToString();
    }
	
	// Update is called once per frame
	void Update () 
	{
		if (juego) {
//		_____________________MOVIMIENTO_____ VERTICAL___________________________________
			if (ver) {
				transform.Translate (Vector2.up * (velocidad * Time.deltaTime));
				if (transform.position.y >= limite_ver) {
					ver = false;
				}

			} else {
				transform.Translate (Vector2.down * (velocidad * Time.deltaTime));
				if (transform.position.y <= limite_ver_n) {

				}

			}
//		_____________________MOVIMIENTO_____ HORIZONTAL___________________________________

			if (hor) {
				transform.Translate (Vector2.left * (velocidad * Time.deltaTime));
				if (transform.position.x <= limite_hor_n) {
					hor = false;
				}

			} else {
				transform.Translate (Vector2.right * (velocidad * Time.deltaTime));
				if (transform.position.x >= limite_hor) {
					hor = true;
				}
			}

			//		_____________________POSICION _____INICIAL___________________________________

			if (transform.position.y <= limite_ver_n) {
                Global.vida = Global.vida - 1;
				text_vida.text = Global.vida.ToString ();
				inicio = true;
				velocidad = 0;
				if (Global.vida <= 0) {
					text_terminado.gameObject.SetActive (true);
					juego = false;
					player.SetActive(false);
                    aux_index = Global.index;
                    Global.index = Global.index - aux_index;
                    print(aux_index);
                    print(Global.index);
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - aux_index);
                }

			}

			if (inicio) {

				transform.position = pos_inicial.position;
				if (Input.GetButtonDown ("Jump")) {
					velocidad = 4;
					inicio = false;
					ver = true;
				}

			}
		
		}
       
    }



	void OnTriggerEnter2D (Collider2D  contacto)
	{
		if (contacto.gameObject.tag == "Player")
        { 
            ver = true;
			velocidad += 0.2f;
        }
        if (contacto.gameObject.tag == "Ladrillo") 
		{
            Global.puntos = Global.puntos + 1;
			text_puntos.text = Global.puntos.ToString (); 
			velocidad += 0.1f;
			contacto.gameObject.SetActive(false);
			if (ver) 
			{
				ver = false;
			} 
			else 
			{
				ver = true;
			}
		}
        if (contacto.gameObject.tag == "Ladrillo2")
        {
            Global.puntos = Global.puntos + 3;
            text_puntos.text = Global.puntos.ToString();
            velocidad += 0.2f;
            contacto.gameObject.SetActive(false);
            if (ver)
            {
                ver = false;
            }
            else
            {
                ver = true;
            }
        }
        if (contacto.gameObject.tag == "Ladrillo3")
        {
            Global.puntos = Global.puntos + 5;
            text_puntos.text = Global.puntos.ToString();
            velocidad += 0.3f;
            contacto.gameObject.SetActive(false);
            if (ver)
            {
                ver = false;
            }
            else
            {
                ver = true;
            }
        }
        if (Global.puntos == 60)
        {
            player.transform.localScale = new Vector2(2, 1);
            //GameObject pawer = Instantiate(pelota2, power.transform);
            //go.transform.localPosition = new Vector2(5,5);
        }
        if (Global.puntos == 25)
        {
            Global.index = Global.index + 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (Global.puntos == 50)
        {
            gana_vida = true;
            sumar_vida();
        }

        if (Global.puntos == 20)
        {
            pelota2.gameObject.SetActive(true);
            //GameObject pod = Instantiate(poder, power);
            ////player.transform.localScale = new Vector2(2, 1);
            //Destroy(pod, 3f);   
        }


        if (Global.puntos == 80)
        {
           
            Global.cargar = true;
            Global.index = Global.index + 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }


        if (Global.puntos == 100)
        {
            gana_vida = true;
            sumar_vida();        }

        if (Global.puntos == 150)
        {
            gana_vida = true;
            sumar_vida();
        }



    }

    void sumar_vida()
    {
        if (gana_vida)
        {
            Global.vida = Global.vida + 1;
            text_vida.text = Global.vida.ToString();
            gana_vida = false;
        }
    }

}
