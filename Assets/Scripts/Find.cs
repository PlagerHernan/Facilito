using UnityEngine;
using System.Collections;

public class Find : MonoBehaviour 
{
	void Awake()
	{
		//busco un objeto (camera) 
		//GameObject camera = GameObject.FindGameObjectWithTag ("MainCamera"); 
		/*GameObject camera = Camera.main.gameObject;
		Debug.Log (camera.transform.position); */

		//busco varios objetos
		/*GameObject[] miArrayDeObjects = GameObject.FindGameObjectsWithTag ("MiTag");

		foreach (GameObject miObject in miArrayDeObjects) 
		{
			Debug.Log (miObject.transform.position);			
		}*/


	}
}
