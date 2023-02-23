using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup3 : MonoBehaviour
{
    public GameObject theKey;
    public GameObject theLeftDoor;
    public GameObject theRightDoor;
    public GameObject theProtect3;

    public AudioSource keySound;
    public AudioSource doorOpenSound;

    void OnTriggerEnter(Collider other)
    {
        Destroy(theKey);
        keySound.Play();
        Destroy(theProtect3);
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorOpen3");
        theRightDoor.GetComponent<Animator>().Play("RightDoorOpen3");
        doorOpenSound.Play();
    }
}
