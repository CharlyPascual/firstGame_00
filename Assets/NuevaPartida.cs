using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NuevaPartida : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CargarNuevaPartida()
    {
        Debug.Log("Cargando Escena: PartidaNueva");
        SceneManager.LoadScene("PartidaNueva");
      
    }
}
