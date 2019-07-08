using UnityEngine;
using System.Collections;

public class Physics : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		 //rigidbody.AddForce (Vector3.forward * 10f, ForceMode.Impulse); //siempre al mismo lugar

		float randomX = Random.Range (-2f, 2f); // Random.Range: devuelve un float random entre parametros min y max

		rigidbody.AddForce (new Vector3(randomX, 0f,1f) * 15f, ForceMode.Impulse); //el vector se va a inicializar con un float random en el eje x
	}
	
	//FixedUpdate (): funcion consistente, evita uso de * Time.deltaTime //solo para fisica//no abusar, xq puede ralentizar el juego
	void FixedUpdate () 
	{
		//rigidbody.AddForce (Vector3.up * 15f, ForceMode.Force); //ForceMode.Force: fuerza continua (tiene en cuenta la masa) 
	}
}
