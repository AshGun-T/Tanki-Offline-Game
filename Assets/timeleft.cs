using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timeleft : MonoBehaviour
{
    public Text txt;
     // Update is called once per frame
    void start(){
    txt = GetComponent<Text>();
    }
    void Update()
    {
       txt.text="Time left";
    }
} 