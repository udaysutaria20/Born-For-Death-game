using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flame_animation : MonoBehaviour
{
    // Start is called before the first frame update
    public int LightMode;
	public GameObject FlameLight;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LightMode == 0) {
			StartCoroutine (AnimateLight ());
		}
    }

    IEnumerator AnimateLight () {
		LightMode = Random.Range (1, 4);
		if (LightMode == 1) {
			FlameLight.GetComponent<Animation> ().Play ("torchAnim1");
		}
		if (LightMode == 2) {
			FlameLight.GetComponent<Animation> ().Play ("torchAnim2");
		}
		if (LightMode == 3) {
			FlameLight.GetComponent<Animation> ().Play ("torchAnim3");
		}
		yield return new WaitForSeconds (0.5f);
		LightMode = 0;

	}
}
