using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup2 : MonoBehaviour
{
    public GameObject theKey;
    public GameObject theLeftDoor;
    public GameObject theRightDoor;
    public GameObject theProtect2;

    public AudioSource keySound;
    public AudioSource doorOpenSound;

    void OnTriggerEnter(Collider other)
    {
        Destroy(theKey);
        keySound.Play();
        Destroy(theProtect2);
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorOpen02");
        theRightDoor.GetComponent<Animator>().Play("RightDoorOpen02");
        doorOpenSound.Play();
    }
}
