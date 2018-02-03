using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel : MonoBehaviour {
	public float tamaño_horizontal;
	public float tamaño_vertical;

	public TextAsset nivel_1;
	public string nombres;

	public GameObject ladrillo;
	// Use this for initialization
	void Start () 
	{
		for (int i =0; i < nombres.Length; i++)
		{
			print (nombres[i]);

		}

		for (int i = 0; i < 5; i++) 
		{
		

			for (int j = 0; j < 5; j++)
			{
			
				GameObject go = Instantiate (ladrillo, this.transform);
				go.transform.localPosition = new Vector2 (i * tamaño_vertical, j * tamaño_horizontal);
			}

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
