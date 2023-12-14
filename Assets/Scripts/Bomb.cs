using UnityEngine;

public class Bomb : MonoBehaviour
{
    int int_vibration;

    int wait;
    float timer;

    private ParticleSystem juiceEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int_vibration = PlayerPrefs.GetInt("int_vibration");
            if (int_vibration == 0){
            Handheld.Vibrate();  
            }

            wait = 1;
        }
    }

    void Awake (){
        juiceEffect = GetComponentInChildren<ParticleSystem>();
    }

    void Update (){
        if (wait >= 1){
        timer += Time.deltaTime;
        juiceEffect.Play();
        if (timer >= 0.1){
            GetComponent<Collider>().enabled = false;
            FindObjectOfType<GameManager>().Explode();
            Destroy(gameObject);

            timer = 0;
            wait = 0;

        }
        }
    }

}
