using UnityEngine;


public class SnareCollision : MonoBehaviour {
    AudioSource SnareAudio;

    void Start()
    {
        SnareAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        SnareAudio.Play();
    }
}
