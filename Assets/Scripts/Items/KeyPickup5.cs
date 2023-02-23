using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup5 : MonoBehaviour
{
    public GameObject theKey;
    public GameObject theLeftDoor;
    public GameObject theRightDoor;
    public GameObject theProtect5;

    public AudioSource keySound;
    public AudioSource doorOpenSound;

    void OnTriggerEnter(Collider other)
    {
        Destroy(theKey);
        keySound.Play();
        Destroy(theProtect5);
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorOpen5");
        theRightDoor.GetComponent<Animator>().Play("RightDoorOpen5");
        doorOpenSound.Play();
    }
}
