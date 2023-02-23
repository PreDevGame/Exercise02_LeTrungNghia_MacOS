using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup1 : MonoBehaviour
{
    public GameObject theKey;
    public GameObject theLeftDoor;
    public GameObject theRightDoor;
    public GameObject theProtect1;

    public AudioSource keyPickupSound;
    public AudioSource doorOpenSound;

    void OnTriggerEnter(Collider other)
    {
        Destroy(theKey);
        keyPickupSound.Play();
        Destroy(theProtect1);
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorOpen");
        theRightDoor.GetComponent<Animator>().Play("RightDoorOpen");
        doorOpenSound.Play();
    }
}
