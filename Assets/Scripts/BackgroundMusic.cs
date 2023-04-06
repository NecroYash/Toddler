using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;

    public void Awake() {
        if(backgroundMusic == null) {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        } else {
            Destroy(gameObject);
        }

        // GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BackgroundMusic");
        // if(musicObj.Length > 1) {
        //     Destroy(this.gameObject);
        // }
        // DontDestroyOnLoad(this.gameObject);
    }
}
