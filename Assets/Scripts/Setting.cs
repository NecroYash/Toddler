using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public void Gender(){
         SceneManager.LoadScene("PilihanGender");
    }
    public void Back(){
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Back To Main Menu");
    }
}
