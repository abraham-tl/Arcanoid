using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel2 : MonoBehaviour {
	public float tamaño_hori;
	public float tamaño_verti;

	public TextAsset nivel_1;
	public string nombres;

    public GameObject ladrillo1;
    public GameObject ladrillo2;
	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < 5; i++) 
		{
		    for (int j = 0; j < 2; j++)
			{
				GameObject go = Instantiate (ladrillo1, this.transform);
				go.transform.localPosition = new Vector2 (i * tamaño_verti, j * tamaño_hori);
			}

		}

        for (int i = 0; i < 5; i++)
        {


            for (int j = 2; j < 5; j++)
            {

                GameObject go = Instantiate(ladrillo2, this.transform);
                go.transform.localPosition = new Vector2(i * tamaño_verti, j * tamaño_hori);
            }

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
