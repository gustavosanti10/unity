using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

	public static int puntos=0;
	public Text textoPuntos;


	public GameObject nivelCompletado;
	public GameObject juegoCompletado;
	public SiguienteNivel siguienteNivel;
	public Pelota pelota;
	public Barra barra;
	public Transform contenedorBloques;
	void Start () {
		ActualizarMarcadorPuntos();
	}

	void ActualizarMarcadorPuntos()
	{
		textoPuntos.text="Puntos: "+Puntos.puntos;
	}
	
	// Update is called once per frame
	public void GanarPunto()
	{
		Puntos.puntos++;
		ActualizarMarcadorPuntos();

		if(contenedorBloques.childCount<=0) //significa que termino el nivel
		{
			pelota.DetenerMovimiento();
			barra.enabled=false; //desactivar barra, el script

			if(siguienteNivel.EsUltimoNivel())
			{
				juegoCompletado.SetActive(true);
			}
			else
			{
				nivelCompletado.SetActive(true);
			}
			siguienteNivel.ActivarCarga();
		}

	}
}
