using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour {

    public GameObject TheGun;
    public GameObject MuzzleFlash;
    public AudioSource GunFire;
    public bool IsFiring = false;
    public float TargetDistance;
    public int DamageAmount = 5;

	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            if (IsFiring == false)
            {
                StartCoroutine(FiringPistol());
            }
        }
		
	}

    IEnumerator FiringPistol ()
    {
        RaycastHit Short;
        IsFiring = true;
        if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Short))
        {
            TargetDistance = Short.distance;
            Short.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        TheGun.GetComponent<Animation>().Play("PistolShot");
        MuzzleFlash.SetActive(true);
        MuzzleFlash.GetComponent<Animation>().Play("MuzzleAnim");
        GunFire.Play();
        yield return new WaitForSeconds(0.5f);
        IsFiring = false;
    }
}