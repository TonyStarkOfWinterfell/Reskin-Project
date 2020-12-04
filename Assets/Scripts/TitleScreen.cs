using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour    
{

    public AudioSource Music;
    public AudioSource Interact;


    void Start()
    {
        PlayMusic();
    }


    public void PlayGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void QuitGame()
    {        
        Application.Quit();
    }


    public void PlayMusic()
    {
        Music.Play();
    }


    public void PlayInteract()
    {
        Interact.Play();
    }
}
