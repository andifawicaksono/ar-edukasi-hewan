using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Exit(){
        Application.Quit();
        Debug.Log("Keluar Game");
    }

    public void Play(){
        SceneManager.LoadScene("PilihanHewan");
    }
}
