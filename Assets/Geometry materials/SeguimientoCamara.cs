using UnityEngine;
using System.Collections;

public class SeguimientoCamara : MonoBehaviour 
{
	[SerializeField]
	Transform Jugador;
	

	void Update () 
	{
		transform.position = new Vector3(Jugador.position.x + 6, transform.position.y, transform.position.z);
	}
}
