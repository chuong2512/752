using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatforMove : MonoBehaviour
{
    public Transform startpostion;
    public GameObject floar;

   
    void Start()
    {
        InvokeRepeating("vehicledelay",0.1f,16.5f);
    }

    public void vehicledelay()

    {
        GameObject floarinstance;
        floarinstance = Instantiate(floar,new Vector3(0,0,125), Quaternion.identity) ;
    }
}
