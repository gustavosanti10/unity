using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour {

	public float velocidad = 0.4f; //variable

	Vector3 posicionInicial;

	//public GameObject ar; //<==KINESTESICO

	public ElementoInteractivo botonIzquierda; //TACTIL
	public ElementoInteractivo botonDerecha; //TACTIL

	// Use this for initialization
	void Start () {
		posicionInicial=transform.position;
	}

	public void Reset()
	{
		transform.position=posicionInicial;
	}
	

	// void Update () { //TECLADO
	// 	float tecladoHorizontal=Input.GetAxisRaw("Horizontal"); //GetAxisRaw obtine numero +,- si se pulsa la tecla
	// 	//float tecladoHorizontal=ar.transform.rotation.z;
	// 	//float posX=transform.position.x+(tecladoHorizontal*velocidad); //*Time.deltaTime
	// 	float posX=transform.position.x+(tecladoHorizontal*velocidad*Time.deltaTime); 
	// 	if(posX>8) posX=8;
	// 	if(posX<-8) posX=-8;
	// 	transform.position=new Vector3(posX, transform.position.y, transform.position.z); //se modifica la posicion
	// }

	// void Update () { //KINESTESICO
		
	// 	float tecladoHorizontal=ar.transform.rotation.z;
	// 	float posX=transform.position.x+(tecladoHorizontal*velocidad); //*Time.deltaTime	
	// 	if(posX>8) posX=8;
	// 	if(posX<-8) posX=-8;
	// 	transform.position=new Vector3(posX, transform.position.y, transform.position.z); //se modifica la posicion
	// }

	void Update () { //TACTIL
		float direccion;
		if(botonIzquierda.pulsado)
		{
			direccion=-1;
		}
		else if(botonDerecha.pulsado)
		{
			direccion=1;
		}
		else
		{
			direccion=Input.GetAxisRaw("Horizontal");
		}
		float posX=transform.position.x+(direccion*velocidad*Time.deltaTime); 
		if(posX>8) posX=8;
		if(posX<-8) posX=-8;
		transform.position=new Vector3(posX, transform.position.y, transform.position.z); //se modifica la posicion
	}
}
