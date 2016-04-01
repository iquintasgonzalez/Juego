using UnityEngine;
using System.Collections;

public class Avanzador : MonoBehaviour 
{
	Rigidbody Jugador;
	
	[SerializeField]
	float Gravedad, Velocidad, Salto;
	
	bool Ganaste;
	
	void Start () 
	{
		Ganaste = false;
		Jugador = GetComponent<Rigidbody>();
	}
	
	void Update () 
	{
		if (!Ganaste)
		{
		if (!Input.GetKey(KeyCode.Escape))
		{
			Physics.gravity = new Vector3(0, -Gravedad, 0);
			if(IsGrounded())
			{
				if (Input.GetButton("Fire1"))
				{
					Jugador.velocity = new Vector3(0, Salto, 0);
				}
			}
			transform.position = new Vector3(transform.position.x + Velocidad, transform.position.y, transform.position.z);
		}
		}
	}
	
	bool IsGrounded()
	{
		return Physics.Raycast(transform.position, -Vector3.up, 0.51f);
	}
	
	void OnTriggerEnter(Collider obj)
	{
		if (obj.tag == "Meta")
		{
			Ganaste = true;
		}
	}
}
