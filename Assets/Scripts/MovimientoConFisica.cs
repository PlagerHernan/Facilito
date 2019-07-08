using UnityEngine;
using System.Collections;

public class MovimientoConFisica : MonoBehaviour {

	public float speed = 10f;

	void FixedUpdate()
	{
		if (Input.GetKey (KeyCode.W))
		{
			rigidbody.MovePosition(rigidbody.position + Vector3.forward * speed * Time.deltaTime);		
		}
		else if (Input.GetKey (KeyCode.S))
		{
			rigidbody.MovePosition(rigidbody.position + Vector3.back * speed * Time.deltaTime);		
		}
		else if (Input.GetKey (KeyCode.A))
		{
			rigidbody.MovePosition(rigidbody.position + Vector3.left * speed * Time.deltaTime);		
		}
		else if (Input.GetKey (KeyCode.D))
		{
			rigidbody.MovePosition(rigidbody.position + Vector3.right * speed * Time.deltaTime);		
		}
	}


}
