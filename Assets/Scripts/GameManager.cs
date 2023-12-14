using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // sounde lose
    public AudioSource sound_lose;
     int int_sound;
    public int a;

    public Text scoreText;

    private Blade blade;
    private Spawner spawner;

    public int score;
    public int life;

    private void Awake()
    {
        blade = FindObjectOfType<Blade>();
        spawner = FindObjectOfType<Spawner>();
    }

    private void Start()
    {
        NewGame();
    }

    public void NewGame()
    {
        Time.timeScale = 1f;

        ClearScene();

        blade.enabled = true;
        spawner.enabled = true;

        a = 0;
        life = 3;
        score = 0;
        PlayerPrefs.SetInt ("life", life); 
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt ("score", score); 
    }

    private void ClearScene()
    {
        Football[] fruits = FindObjectsOfType<Football>();

        foreach (Football fruit in fruits) {
            Destroy(fruit.gameObject);
        }

        Bomb[] bombs = FindObjectsOfType<Bomb>();

        foreach (Bomb bomb in bombs) {
            Destroy(bomb.gameObject);
        }
    }

    public void IncreaseScore(int points)
    {
        score += points;
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt ("score", score); 
    }

    public void Explode()
    {
        if (life > 0){
        life -= 1;
        PlayerPrefs.SetInt ("life", life); 
        }
    }

    void Update ()
    {   
        int_sound = PlayerPrefs.GetInt("int_sound");
        score = PlayerPrefs.GetInt("score");
        life = PlayerPrefs.GetInt("life");

        if (life <= 0){

            if (a == 0){
            if (int_sound <= 0){
            sound_lose.Play();
            a = 1;
            }
            }

            blade.enabled = false;
            spawner.enabled = false;
        }

    }

}
