using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Setting(){
         SceneManager.LoadScene("Pengaturan");
    }
    public void Exit(){
        Application.Quit();
        Debug.Log("You Close The App");
    }
}
