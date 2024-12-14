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
		if (Input.GetKeyDown(KeyCode.R) || BowlingBallIsOut()) // Si presiono la tecla R o s� la bola est� fuera de la pista
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

	private bool BowlingBallIsOut() // Funci�n para calcular si la bola sali� de la pista
	{
		if (bowlingBall.transform.position.z > bowlingAlleyLength)
		{
			return true;
		}
		return false;
	}
}
