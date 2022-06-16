using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zsf : MonoBehaviour
{
    // Start is called before the first frame update
    public static int scoreAmount;
    private Text scoreText;
    // ShadowscoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreAmount;
        //ShadowscoreText.text = "Score: " + scoreAmount;
     if(scoreAmount>PlayerPrefs.GetInt("highscore"))
         PlayerPrefs.SetInt("highscore",scoreAmount);
    
     //SceneManager.LoadScene("Mainmenu");
    }
}
