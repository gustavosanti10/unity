using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour {

	// Use this for initialization

	public string nivelACargar;
	public float retraso;

	[ContextMenu("Activar Carga")]
	public void ActivarCarga()
	{
		Invoke("CargarNivel", retraso);
	}

	void CargarNivel()
	{
		if(!EsUltimoNivel())
		{
			Vidas.vidas++;
		}
		SceneManager.LoadScene(nivelACargar);
	}

	public bool EsUltimoNivel()
	{
		if(nivelACargar=="Portada")
		{
			return true;
		}
		else
		{
			return false;
		}
	}

}
