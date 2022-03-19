using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{

    public GameObject score;
    public GameObject gameOverText;
    public PlayerMovement playerMovement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            gameOverText.SetActive(true);
            playerMovement.gameOver = true;
            score.GetComponent<PlayerScore>().gameover = true;
            Invoke("RestartScene", 3);
        }
    }

    void FixedUpdate() {
        if (Input.GetKey("r")) 
        {
            RestartScene();
        }    
    }

    public void RestartScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }
}
