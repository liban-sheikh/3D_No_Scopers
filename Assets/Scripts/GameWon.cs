using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWon : MonoBehaviour {
	
	IEnumerator OnTriggerEnter (Collider collision)
	{
		if (collision.gameObject.tag == "GameWon") {
            Debug.Log("Game Won!");
			SceneManager.LoadScene ("Credit Scene");
		}
		yield return new WaitForSeconds (1);
	}
}
