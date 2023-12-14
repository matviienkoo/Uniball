using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Panel : MonoBehaviour
{
    // music
    public AudioSource music;
    int int_music;

    public GameObject music_on;
    public GameObject music_off;

    // sound
    public AudioSource sound;
    public AudioSource sound_play;
    int int_sound;
    int int_sound_play;

    float timer;

    public GameObject sound_on;
    public GameObject sound_off;

    // vibration
    int int_vibration;

    public GameObject vibration_on;
    public GameObject vibration_off;

    // language
    public string language;
    Text text;

    // records
    public int best_score;
    public Text your_best_text;
    public int your_score;
    public Text your_score_text;
    
    // transtion objects
    public GameObject SETTING_object;
    public GameObject RECORD_object;

    // life
    public int life;

    public void Play (){
        if (int_sound == 0){
        sound_play.Play();
        }

        int_sound_play = 1;
    }

    public void Menu (){
        SceneManager.LoadScene ("Start_Scene");
    }

    public void Setting (){
        if(SETTING_object != null){
        SETTING_object.SetActive(true);
        }
    }
    public void Record (){
        if(RECORD_object != null){
        RECORD_object.SetActive(true);
        }
    }
    public void Back (){
        if(SETTING_object != null){
        SETTING_object.SetActive(false);
        }
        if(RECORD_object != null){
        RECORD_object.SetActive(false);
        }
    }

    public void english_language (){
        string language = "eng";
        PlayerPrefs.SetString("Lang", language);
    }

    public void russian_language (){
        string language = "Rus";
        PlayerPrefs.SetString("Lang", language);
    }

    public void Music_on_off (){
        int_music += 1;

        if (int_music == 1){

            if(music_off != null){
            music_off.SetActive(true);
            }
            if(music_on != null){
            music_on.SetActive(false);
            }

        }
        if (int_music == 2){
            int_music = 0;

            if(music_off != null){
            music_off.SetActive(false);
            }
            if(music_on != null){
            music_on.SetActive(true);
            }
        }

        PlayerPrefs.SetInt ("int_music", int_music);
    }

    public void Sound_on_off (){
        int_sound += 1;

        if (int_sound == 1){

            if(sound_off != null){
            sound_off.SetActive(true);
            }
            if(sound_on != null){
            sound_on.SetActive(false);
            }

        }
        if (int_sound == 2){
            int_sound = 0;

            if(sound_off != null){
            sound_off.SetActive(false);
            }
            if(sound_on != null){
            sound_on.SetActive(true);
            }
        }

        PlayerPrefs.SetInt ("int_sound", int_sound); 
    }

    public void Vibration (){
        int_vibration += 1;

        if (int_vibration == 1){

            if(vibration_off != null){
            vibration_off.SetActive(true);
            }
            if(vibration_on != null){
            vibration_on.SetActive(false);
            }

        }
        if (int_vibration == 2){
            int_vibration = 0;

            if(vibration_off != null){
            vibration_off.SetActive(false);
            }
            if(vibration_on != null){
            vibration_on.SetActive(true);
            }
        }

        PlayerPrefs.SetInt ("int_vibration", int_vibration); 
    }

    public void Click (){
        if (int_sound == 0){
        sound.Play();
        }
    }

    void Update (){
        your_score = PlayerPrefs.GetInt("your_score");
        your_score_text.text = your_score.ToString();

        best_score = PlayerPrefs.GetInt("best_score");
        your_best_text.text = best_score.ToString();

        int_vibration = PlayerPrefs.GetInt("int_vibration");
        int_music = PlayerPrefs.GetInt("int_music");
        int_sound = PlayerPrefs.GetInt("int_sound");

        life = PlayerPrefs.GetInt("life");

        text = GetComponent<Text>();
        language = PlayerPrefs.GetString("Lang");

        if (int_music == 0){
            if(music_off != null){
            music_off.SetActive(false);
            }
            if(music_on != null){
            music_on.SetActive(true);
            }
        }
        if (int_music >= 1){
            if(music_off != null){
            music_off.SetActive(true);
            }
            if(music_on != null){
            music_on.SetActive(false);
            }
        }

        if (int_sound == 0){
            if(sound_off != null){
            sound_off.SetActive(false);
            }
            if(sound_on != null){
            sound_on.SetActive(true);
            }
        }
        if (int_sound >= 1){
            if(sound_off != null){
            sound_off.SetActive(true);
            }
            if(sound_on != null){
            sound_on.SetActive(false);
            }
        }

        if (int_vibration == 0){
            if(vibration_off != null){
            vibration_off.SetActive(false);
            }
            if(vibration_on != null){
            vibration_on.SetActive(true);
            }
        }
        if (int_vibration >= 1){
            if(vibration_off != null){
            vibration_off.SetActive(true);
            }
            if(vibration_on != null){
            vibration_on.SetActive(false);
            }
        }

        if (int_sound_play == 1){
            timer += Time.deltaTime;
            if (timer >= 1){
            SceneManager.LoadScene ("Game_Scene");
            }
        }
    }
 
}
