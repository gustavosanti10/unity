using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {

	public float velocidadInicial=600f;
	public Rigidbody rig;
	bool enJuego; //false incial
	Vector3 posicionInicial;
	public Transform barra;


	public ElementoInteractivo pantallaInicio;

	// Use this for initialization
	// void Awake()
	// {
	// 	rig=GetComponent<Rigidbody>();
	// }

	// void Awake()
	// {
	// 	barra=GetComponentInParent<Transform>();
	// }

	void Start () {

		posicionInicial=transform.position;

	}

	public void Reset()
	{
		transform.position=posicionInicial;
		transform.SetParent(barra);
		enJuego=false;
		DetenerMovimiento();
	}

	public void DetenerMovimiento()
	{
		rig.isKinematic=true;
		rig.velocity=Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {

		if(!enJuego && (Input.GetButtonDown("Fire1") || pantallaInicio.pulsado))
		{
			enJuego=true;
			transform.SetParent(null); //dejar de ser hija
			rig.isKinematic=false;
			rig.AddForce(new Vector3(velocidadInicial, velocidadInicial, 0));

		}
		
	}
}
