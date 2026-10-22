using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{

    AudioSource source;

    Collider2D soundTrigger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    {
        source.Play();
    }
}