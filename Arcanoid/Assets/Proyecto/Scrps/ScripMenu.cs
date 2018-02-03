using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScripMenu : MonoBehaviour {

	// Use this for initialization
public void Jugar()
    {
        Global.index = Global.index + 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
