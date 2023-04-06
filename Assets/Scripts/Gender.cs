using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gender : MonoBehaviour
{
    public void ChooseBoy(){
         SceneManager.LoadScene("Pengaturan");
         Debug.Log("You Choose Boy Gender");
    }
    public void ChooseGirl(){
        SceneManager.LoadScene("Pengaturan");
        Debug.Log("You Choose Girl Gender");
    }
}
