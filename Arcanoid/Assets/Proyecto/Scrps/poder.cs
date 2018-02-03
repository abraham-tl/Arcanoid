using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class poder : MonoBehaviour {
    public GameObject player;
    //public GameObject bola;
    
    public Transform posision;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            gameObject.SetActive(false);
        }
    }
}
