using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BawllingBallBehavior : MonoBehaviour
{
    Rigidbody BowlingBallRB;

	private float move;
	private float force = 0f;
	private float speedMoveX = 1f;
	private float xBallLimit = 0.8f;
	private float MAXForce = 1000f;
	private float chargeSpeed = 250f;

	private void Start()
	{
		BowlingBallRB = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		// Movimiento de la bola
		float move = Input.GetAxis("Horizontal") * speedMoveX * Time.deltaTime;
		transform.Translate(move, 0, 0);
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xBallLimit, xBallLimit), transform.position.y, transform.position.z); // Marco el límite de movimiento horizontal de la bola

		// Lanzamiento de la bola
		if (Input.GetKey(KeyCode.Space))
		{
			force += chargeSpeed * Time.deltaTime;
			force = Mathf.Clamp(force, 0, MAXForce); // Aseguro que no se pase de los valores mínimos y máximos
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			BowlingBallRB.AddForce(Vector3.forward * force); // Lanza la bola hacia adelante si suelto la tecla Espacio
			force = 0; // Vuelve la fuerza a cero
		}
	}
}
