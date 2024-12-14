using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameConfig : MonoBehaviour
{
	public GameObject bowlingBall; // bola
	private float bowlingAlleyLength = 12f; // largo de la pista
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.R) || BowlingBallIsOut()) // Si presiono la tecla R o sí la bola está fuera de la pista
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

	private bool BowlingBallIsOut() // Función para calcular si la bola salió de la pista
	{
		if (bowlingBall.transform.position.z > bowlingAlleyLength)
		{
			return true;
		}
		return false;
	}
}
