using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class platform : MonoBehaviour
{
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (SceneManager.GetActiveScene().buildIndex <= 15)
        //{
        //    speed = 9;
        //}
        //else if (SceneManager.GetActiveScene().buildIndex <= 25)
        //{
        //    speed = 18;
        //}
        //else if (SceneManager.GetActiveScene().buildIndex <= 50)
        //{
        //    speed = 24;
        //}
        //else if (SceneManager.GetActiveScene().buildIndex <= 100)
        //{
        //    speed = 30;
        //}
        speed = 9;
        transform.Translate(0, 0, -speed * Time.deltaTime);
    }

}
