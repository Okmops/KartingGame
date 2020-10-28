
using UnityEngine;

public class MusicSurprise : MonoBehaviour
{
    public AudioClip Surprise;
    public float volume;
    AudioSource audio;
    public bool alreadyPlayed = false;


    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag =="Player") & (!alreadyPlayed))

        {
            audio.PlayOneShot(Surprise, volume);
            alreadyPlayed = true;
            Debug.Log("Wjechało");
        }
    }

}
