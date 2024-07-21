using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBurung : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public void Back(){
        SceneManager.LoadScene("PilihanHewan");
    }

    public void PlayBurungSound(){
        source.clip = clip;
        source.Play();
    }
}
