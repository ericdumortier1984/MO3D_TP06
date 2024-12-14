using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuerzaIndicator : MonoBehaviour
{
	public GameObject emptyBar; 
	public GameObject powerBar; 
	private float force = 0f; // Fuerza inicial
	private float maxForce = 1000f; // Fuerza máxima

	void Update()
	{
		if (Input.GetKey(KeyCode.Space) && force < maxForce)
		{
			force += Time.deltaTime * 250f; // Incremento de fuerza
		}
		else if (Input.GetKeyUp(KeyCode.Space) && force > 0)
		{
			force -= Time.deltaTime * 250f; // Decremento de fuerza
		}

		UpdatePowerBar();
	}

	void UpdatePowerBar() // Función para actualizar la barra de potencia de lanzamiento
	{
		float normalizedForce = force / maxForce;
		Vector3 newScale = new Vector3(1f, normalizedForce * 2f, 1f); // Ancho y alto de la barra de potencia
		powerBar.transform.localScale = newScale; // Actualiza la escala de la barra

        float positionChargeBar = emptyBar.transform.localPosition.z - (emptyBar.transform.localScale.z / 2) + (newScale.z / 2); // posición barra de potencia
		powerBar.transform.localPosition = new Vector3(emptyBar.transform.localPosition.x, emptyBar.transform.localPosition.y, positionChargeBar);
	}
}

