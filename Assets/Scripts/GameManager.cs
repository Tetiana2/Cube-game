
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public float timeDelay = 1f;
    public Text gameOverText;
    public GameObject completeLevel1UI;
    
    public void Start()
    {
        
    }
    public void LevelComplete()
    {
        completeLevel1UI.SetActive(true);
    }
    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", timeDelay);
            gameOverText.text = "Game Over";
        }
        
       
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
