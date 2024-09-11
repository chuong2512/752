﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeKnife : MonoBehaviour
{
    public GameObject fracterdknife;

    private void Awake()
    {
        fracterdknife = FindObjectOfType<PlayerInputManager>().facturedknife;
    }

    public void OnTriggerEnter(Collider collision)
    {
      
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("sd");
           
            Destroy(collision.gameObject);
            fracterdknife.SetActive(true);
            for(int i = 0; i < fracterdknife.transform.childCount; i++)
            {
                if (fracterdknife.transform.GetChild(i).GetComponent<Rigidbody>())
                {
                    fracterdknife.transform.GetChild(i).GetComponent<Rigidbody>().isKinematic = false;
                    Invoke("levelfailui",2f);
                }
            }
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    public void levelfailui()
    {
        FindObjectOfType<GameManager>().LevelFail();
        FindObjectOfType<GameManager>().gameover();
    }


}
