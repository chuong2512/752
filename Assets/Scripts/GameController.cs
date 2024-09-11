using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    
    public GameObject cucuparticale, tamatoparticale, brizalparticale, mashroomparticale, bombparticale;
    public Rigidbody rb;
    public float totalscore;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}

	void Update ()
    {
        
	}

    public void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag + other.gameObject.name);
        if (other.gameObject.tag == "cucu")
        {
            FindObjectOfType<GameManager>().score++;
            Debug.Log(((FindObjectOfType<GameManager>().score))/totalscore);
            FindObjectOfType<GameManager>().fill1.fillAmount = ( (FindObjectOfType<GameManager>().score) /totalscore);
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            rb.AddForce(0, 0,-0.5f);
            
            Instantiate(cucuparticale, this.transform.position, this.transform.rotation);
        }

        if (other.gameObject.tag == "tamoto")
        {
            FindObjectOfType<GameManager>().score++;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            Instantiate(tamatoparticale, this.transform.position, this.transform.rotation);
        }

        if (other.gameObject.tag == "brizal")
        {
            FindObjectOfType<GameManager>().score++;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            Instantiate(brizalparticale, this.transform.position, this.transform.rotation);
        }

        if (other.gameObject.tag == "mashroom")
        {
            FindObjectOfType<GameManager>().score++;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            Instantiate(mashroomparticale, this.transform.position, this.transform.rotation);
        }

        if (other.gameObject.tag == "bomb")
        { 
            Destroy(other.gameObject);
            Instantiate(bombparticale, this.transform.position, this.transform.rotation);
        }

    }
}
