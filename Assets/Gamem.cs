using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamem : MonoBehaviour {

	bool gameHasEnded = false;
    public float timeleft= 60.0f;
	public float restartDelay = 5f;

	public GameObject completeLevelUI;

	public void CompleteLevel ()
	{   //Debug.Log("Won");
		completeLevelUI.SetActive(true);
	}

    void Update() {
        timeleft -= Time.deltaTime;
        if(timeleft <= 0) {
            completeLevelUI.SetActive(true);
            gameHasEnded = false;
            EndGame();
        }
    }
    
	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			//Debug.Log("GAME OVER");
            Time.timeScale = 0f;
			//Invoke("Restart", restartDelay);
		}
	}
    
    
	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
