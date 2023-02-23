using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoldierScoreBoard : MonoBehaviour
{
    [SerializeField]
    private int manyOfSolider;
    public GameObject soldierValue;

    void Start()
    {
        manyOfSolider = 0;
    }
    void Update()
    {
        manyOfSolider = GunFire.theSoliderKilled;
        soldierValue.GetComponent<Text>().text = "" + manyOfSolider;
    }
}
