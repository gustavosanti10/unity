using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //<=====

public class BotonSalir : MonoBehaviour {

	public bool salir;
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(salir)
			{
				Debug.Log("Salimos");
				Application.Quit();
			}
			else
			{
				//Application.LoadLevel("Portada");
				SceneManager.LoadScene("Portada");
			}
			
		}
	}
}
