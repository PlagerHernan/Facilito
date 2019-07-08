using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 
{
	public float deltaRotation = 10f;
	public float deltaMovement = 10f;
	public Color color;

	// Start (): se ejecuta una sola vez al iniciar el juego
	void Start () 
	{
		renderer.material.color = color;

	}

	// Update(): se ejectuta una vez por frame
	void Update () 
	{
		Rotate ();
		Movement ();
	}

	void Rotate()
	{
		if (Input.GetKey(KeyCode.Q)) 
			transform.Rotate (new Vector3 (0f, -deltaRotation, 0f) * Time.deltaTime); //* Time.deltaTime: para hacerlo consistente en cualquier dispositivo
		else if (Input.GetKey(KeyCode.E)) 
			transform.Rotate (new Vector3 (0f, deltaRotation, 0f) * Time.deltaTime);
	}

	void Movement()
	{
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.Translate(Vector3.forward * deltaMovement * Time.deltaTime);
			//MoverCuerpo ();
		}
			
		else if (Input.GetKey (KeyCode.S))
		{
			transform.Translate(Vector3.back * deltaMovement * Time.deltaTime);
			//MoverCuerpo ();
		}
			
		else if (Input.GetKey (KeyCode.A))
		{
			transform.Translate(Vector3.left * deltaMovement * Time.deltaTime);
			//MoverCuerpo ();
		}
			
		else if (Input.GetKey (KeyCode.D))
		{
			transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);
			//MoverCuerpo ();
		}
			
	}

	/*void MoverCuerpo()
	{
		GameObject PiernaDerecha = GameObject.Find ("PiernaDerecha"); 
		//PiernaDerecha.transform.Rotate (new Vector3 (-deltaRotation, 0f, 0f) * Time.deltaTime);
		//PiernaDerecha.transform.rotation.Set (0f, 0f, 0f, 0f); //no funca


		/*PiernaDerecha.transform.position = new Vector3 (0f, 5f, 0f);
		PiernaDerecha.transform.position.Set (0f, 0f, 0f);*/

		/*PiernaDerecha.transform.Translate(Vector3.forward * deltaMovement * Time.deltaTime);
		PiernaDerecha.transform.Translate(Vector3.back * deltaMovement * Time.deltaTime);
	}*/
}

