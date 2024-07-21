using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PilihanHewan : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickBtnRusa(){
        //PlayAnimationSound();
        SceneManager.LoadScene("Play");
    }

    public void ClickBtnMonyet(){
        //PlayAnimationSound();
        SceneManager.LoadScene("PlayMonyet");
    }

    public void ClickBtnBurung(){
        //PlayAnimationSound();
        SceneManager.LoadScene("PlayBurung");
    }

    public void Exit(){
        Application.Quit();
        Debug.Log("Keluar Game");
    }
    public void Back(){
        SceneManager.LoadScene("MainMenu");
    }
    public void PlayAnimationSound(){
        source.clip = clip;
        source.Play();
    }
}
