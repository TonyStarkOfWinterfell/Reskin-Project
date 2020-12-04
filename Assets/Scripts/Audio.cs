using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip AppleClip;
    public AudioClip JumpClip;
    public AudioClip DeathClip;
    public AudioSource MusicSource;
    public AudioSource Background;
          


    // Start is called before the first frame update
    void Start()
    {
        PlayBackground();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {            
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(JumpClip);                                 
        }        
    }


    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.name == "Food")
        {            
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(AppleClip);
        }

        if (trig.gameObject.tag == "Enemy")
        {
            AudioSource audio = GetComponent<AudioSource>();
            Background.Stop();
            audio.PlayOneShot(DeathClip);
        }
    }    

    public void PlayBackground()
    {
        Background.Play();
    }
}
