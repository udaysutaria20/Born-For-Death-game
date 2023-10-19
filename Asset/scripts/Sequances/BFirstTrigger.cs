using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BFirstTrigger : MonoBehaviour
{
   public GameObject ThePlayer;
	public GameObject TextBox;
	public GameObject TheMarker;
    public GameObject Trigger;

	void OnTriggerEnter () {
		ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
		StartCoroutine (ScenePlayer ());
	}

	IEnumerator ScenePlayer() {
		TextBox.SetActive (true);
		yield return new WaitForSeconds (2.5f);
        TextBox.SetActive (false);
		ThePlayer.GetComponent<FirstPersonController> ().enabled = true;
		TheMarker.SetActive (true);
        Trigger.SetActive(false); 
	}
}
