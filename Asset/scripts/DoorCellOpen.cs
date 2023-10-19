using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorCellOpen : MonoBehaviour
{
    public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject TheDoor;
	public AudioSource CreakSound;
    public GameObject ExtraCross;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }


    void OnMouseOver () {
		if (TheDistance <= 2.5) {
            ExtraCross.SetActive(false);
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
				TheDoor.GetComponent<Animation> ().Play ("first_door_open_anim");
				CreakSound.Play ();
			}
		}
        
	}

	void OnMouseExit() {
        ExtraCross.SetActive(true);
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
}
