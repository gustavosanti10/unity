using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour {

	public Puntos puntos;

	void OnCollisionEnter()
	{
		Destroy(gameObject);
		transform.SetParent(null);
		puntos.GanarPunto();

	}

	// void OnTriggerEnter()
	// {
		
	// }
}
