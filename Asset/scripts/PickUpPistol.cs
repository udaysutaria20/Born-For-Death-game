using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PickUpPistol : MonoBehaviour
{
    
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject FakePistol;
	public GameObject RealPistol;
	public GameObject GuideArrow;
	public GameObject ExtraCross;
	public GameObject JumpTrigger;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 2.5) {
			ExtraCross.SetActive (false);
			ActionText.SetActive(true);
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}
		else{
            ExtraCross.SetActive(true);
            ActionDisplay.SetActive (false);
		    ActionText.SetActive (false);
        }
		if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 2.5) {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				FakePistol.SetActive (false);
				RealPistol.SetActive (true);
				GuideArrow.SetActive (false);
				ExtraCross.SetActive (true);
				JumpTrigger.SetActive(true);
			}
		}
	}

	void OnMouseExit() {
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
}
