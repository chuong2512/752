using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    public GameObject levelcomplete,levelfail,ingame;

    public Text leveltext,scoretext;

    public Image fill1;

    public int score;

    public GameObject particale;



    public float speed;
	void Start ()
    {
        leveltext.text ="LEVEL"+(SceneManager.GetActiveScene().buildIndex).ToString();
	}

    int i = 0;
	
	void Update ()
    {
         
        scoretext.text = score.ToString();
        if (fill1.fillAmount == 1 && i==0)
        {
            FindObjectOfType<cameramove>().enabled=true;
            gameover();
               
            Invoke("LevelComplete", 3f);

            Instantiate(particale,new Vector3(100,25,61),Quaternion.Euler(23,29,-4));
            i = 1;
        }
      
	}

    public void LevelComplete()
    {
       
        levelcomplete.SetActive(true);
        ingame.SetActive(false);
    }
    public void LevelFail()
    {
        levelfail.SetActive(true);
        ingame.SetActive(false);
    }
    public void RestartButton()
    {
        if (AdManager.instance)
        {
            AdManager.instance.ShowAd();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextButton()
    {
        if (AdManager.instance)
        {
            AdManager.instance.ShowAd();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void gameover()
    {
        FindObjectOfType<PlayerInputManager>().enabled = false;
        FindObjectOfType<PlayerInputManager>().GetComponent<Animator>().enabled = false;
        //FindObjectOfType<GameController>().GetComponent<BoxCollider>().enabled = false;
        FindObjectOfType<BrakeKnife>().GetComponent<BoxCollider>().enabled = false;
        FindObjectOfType<PlatforMove>().enabled = false;

        FindObjectOfType<platform>().enabled = false;
    }

}
