using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {

	public static int vidas=3;

	public Text textoVidas;

	public Pelota pelota;
	public Barra barra;


	public GameObject gameOver;
	public SiguienteNivel siguienteNivel;

	void Start () {
		ActualizarMarcadorVidas();
	}

	void ActualizarMarcadorVidas()
	{
		textoVidas.text="Vidas: "+Vidas.vidas;
	}
	
	public void PerderVida()
	{
		if(Vidas.vidas<=0) return;

		Vidas.vidas--;
		ActualizarMarcadorVidas();

		if(Vidas.vidas<=0)
		{
			gameOver.SetActive(true); //activo el mensaje
			pelota.DetenerMovimiento();
			barra.enabled=false; //desactivar barra, el script

			siguienteNivel.nivelACargar="Portada";
			siguienteNivel.ActivarCarga();
		}
		else
		{ //para que siga jugando

			barra.Reset();
			pelota.Reset();
		}

		

	}
}
