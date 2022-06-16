using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
//using UnityEngine.SceneManagement;

public class highscore : MonoBehaviour
{
    public Text hscore;
    // Start is called before the first frame update
    void Start()
    { // PlayerPrefs.SetInt("highscore",0);
        hscore.text="Highscore: " +  PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
