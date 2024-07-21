using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;

    public void Back(){
        SceneManager.LoadScene("PilihanHewan");
    }

    public void PlayRusaSound(){
        source.clip = clip;
        source.Play();
    }
}
