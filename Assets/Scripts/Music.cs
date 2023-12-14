
using UnityEngine;

public class Music : MonoBehaviour
{
    // music
    public AudioSource music;
    [SerializeField]private string createdTag;

    int int_music;

    void Update (){
        int_music = PlayerPrefs.GetInt("int_music");

        if (int_music == 0){
        if (music.isPlaying) return;
         music.Play();
        }
        if (int_music >= 1){
         music.Stop();
        }
    }

    void Awake()
    {
        GameObject obj = GameObject.FindWithTag(this.createdTag);

        if (obj != null){
            Destroy(this.gameObject);
        }

        else
        {
            this.gameObject.tag = this.createdTag;
            DontDestroyOnLoad(this.gameObject);
        }
    }
 
}
