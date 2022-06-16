using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class zombiescore : MonoBehaviour
{ 
    public Text scoreText;
    public float timel;
    public float timeleft= 60.0f;
    // Update is called once per frame
    void start(){
    scoreText = GetComponent<Text>();
    }
    void Update()
    {if(timeleft>=0f)
        { 
        //scoreText.text=timeleft.ToString() - Time.deltaTime.ToString();
        timeleft-=Time.deltaTime;}
        scoreText.text="Time left  \n " + timeleft.ToString("0");
    }
}
