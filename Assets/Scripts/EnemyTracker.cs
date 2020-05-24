using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTracker : MonoBehaviour {

	public GameObject Marker;
	public GameObject Mark0;
	public GameObject Mark1;
	public GameObject Mark2;
	public GameObject Mark3;
	public GameObject Mark4;
	public GameObject Mark5;
	public GameObject Mark6;
	public GameObject Mark7;
	public GameObject Mark8;
	public GameObject Mark9;
	public GameObject Mark10;
	public GameObject Mark11;
	public GameObject Mark12;
	public GameObject Mark13;
	public GameObject Mark14;
	public GameObject Mark15;
	public GameObject Mark16;
	public GameObject Mark17;
	public int markTracker;

	void Update () {

		if (markTracker == 0) {
			Marker.transform.position = Mark0.transform.position;
		}

		if (markTracker == 1) {
			Marker.transform.position = Mark1.transform.position;
		}

		if (markTracker == 2) {
			Marker.transform.position = Mark2.transform.position;
		}

		if (markTracker == 3) {
			Marker.transform.position = Mark3.transform.position;
		}

		if (markTracker == 4) {
			Marker.transform.position = Mark4.transform.position;
		}

		if (markTracker == 5) {
			Marker.transform.position = Mark5.transform.position;
		}

		if (markTracker == 6) {
			Marker.transform.position = Mark6.transform.position;
		}

		if (markTracker == 7) {
			Marker.transform.position = Mark7.transform.position;
		}

		if (markTracker == 8) {
			Marker.transform.position = Mark8.transform.position;
		}

		if (markTracker == 9) {
			Marker.transform.position = Mark9.transform.position;
		}

		if (markTracker == 10) {
			Marker.transform.position = Mark10.transform.position;
		}

		if (markTracker == 11) {
			Marker.transform.position = Mark11.transform.position;
		}

		if (markTracker == 12) {
			Marker.transform.position = Mark12.transform.position;
		}

		if (markTracker == 13) {
			Marker.transform.position = Mark13.transform.position;
		}

		if (markTracker == 14) {
			Marker.transform.position = Mark14.transform.position;
		}

		if (markTracker == 15) {
			Marker.transform.position = Mark15.transform.position;
		}

		if (markTracker == 16) {
			Marker.transform.position = Mark16.transform.position;
		}

		if (markTracker == 17) {
			Marker.transform.position = Mark17.transform.position;
		}
	}

	IEnumerator OnTriggerEnter (Collider collision)
	{
		if (collision.gameObject.tag == "AIEnemy") {

			this.GetComponent<BoxCollider> ().enabled = false;
			markTracker += 1;
			if (markTracker == 12) {
				markTracker = 0;
				SceneManager.LoadScene ("Credit Scene");
			}
			yield return new WaitForSeconds (1);
			this.GetComponent<BoxCollider> ().enabled = true;
		}
	}
}
