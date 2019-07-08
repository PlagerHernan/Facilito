using UnityEngine;
using System.Collections;

public class Instanciar : MonoBehaviour 
{
	public GameObject prefab; //declaro una variable publica de tipo GameObject,  para asignar un prefab desde Unity  
	public GameObject cube;
	int count = 0;

	// Use this for initialization
	void Start () 
	{
		//Instantiate (prefab, transform.position, transform.rotation); //instancia un objeto, en la misma posicion y rotacion 
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) //GetKeyUp: a diferencia de GetKey, solo se acciona cuando suelto la tecla (no mientras esta apretada) 
												//GetKeyDown: cuando aprieto la tecla
		{
			cube = Instantiate (prefab, transform.position, transform.rotation) as GameObject; //as GameObject: casteo de Object a GameObject
			cube.name = "foo" + count++; //le asigno un nombre diferente a cada cubo que se instancia, para reconocerlos entre ellos 
			//Destroy (cube, 2f); //los destruyo despues de 2 segundos
		} 
	}
}
