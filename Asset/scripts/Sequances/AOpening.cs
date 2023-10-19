using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AOpening : MonoBehaviour
{
    public GameObject ThePlayer;
	public GameObject FadeScreenIn;
	public GameObject TextBox;

	void Start () {
		ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
		StartCoroutine (ScenePlayer ());
	}

	IEnumerator ScenePlayer () {
		yield return new WaitForSeconds (1.5f);
		FadeScreenIn.SetActive (false);

		TextBox.SetActive(true);
		yield return new WaitForSeconds (2);
		TextBox.SetActive(false);
		ThePlayer.GetComponent<FirstPersonController> ().enabled = true;
		
	}
}
