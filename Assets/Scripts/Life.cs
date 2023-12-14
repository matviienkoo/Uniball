using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public GameObject GameOver;

    public GameObject First_Life;
    public GameObject Second_Life;
    public GameObject Thirt_Life;

    public Text your_score_text;
    public int best_score;
    public int your_score;
    public int score;

    int int_vibration;
    public int life;

    private void OnTriggerEnter(Collider other){
    if (other.CompareTag("ball")){
        if (life >= 1){

        if (int_vibration == 0){
        Handheld.Vibrate();  
        }

        life -= 1;
        PlayerPrefs.SetInt ("life", life); 
        }
    }
    }

    void Update (){
        int_vibration = PlayerPrefs.GetInt("int_vibration");
        best_score = PlayerPrefs.GetInt("best_score");
        your_score = PlayerPrefs.GetInt("your_score");
        your_score_text.text = your_score.ToString();
        score = PlayerPrefs.GetInt("score");
        life = PlayerPrefs.GetInt("life");

        if (life == 3){
            if(First_Life != null){
            First_Life.SetActive(true);
            }
            if(Second_Life != null){
            Second_Life.SetActive(true);
            }
            if(Thirt_Life != null){
            Thirt_Life.SetActive(true);
            }

            if(GameOver != null){
            GameOver.SetActive(false);
            }
        }
        if (life == 2){
            if(First_Life != null){
            First_Life.SetActive(false);
            }
            if(Second_Life != null){
            Second_Life.SetActive(true);
            }
            if(Thirt_Life != null){
            Thirt_Life.SetActive(true);
            }
        }
        if (life == 1){
            if(First_Life != null){
            First_Life.SetActive(false);
            }
            if(Second_Life != null){
            Second_Life.SetActive(false);
            }
            if(Thirt_Life != null){
            Thirt_Life.SetActive(true);
            }
        }
        if (life <= 0){
            if(First_Life != null){
            First_Life.SetActive(false);
            }
            if(Second_Life != null){
            Second_Life.SetActive(false);
            }
            if(Thirt_Life != null){
            Thirt_Life.SetActive(false);
            }

            your_score = score;
            PlayerPrefs.SetInt ("your_score", your_score); 

            if (best_score < score){
            best_score = score;
            PlayerPrefs.SetInt ("best_score", best_score); 
            }

            // end
            if(GameOver != null){
            GameOver.SetActive(true);
            }
        }
    // End Update
    }
}
