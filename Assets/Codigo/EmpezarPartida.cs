using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //<===

public class EmpezarPartida : MonoBehaviour {

	public ElementoInteractivo pantallaInicio;
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Fire1") || pantallaInicio.pulsado)
		{
			Puntos.puntos=0;
			Vidas.vidas=3;
			SceneManager.LoadScene("Nivel01");
			
		}
	}
}
