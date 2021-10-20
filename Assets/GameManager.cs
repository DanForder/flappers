using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public bool active;
    public GameObject gameOverCanvas;
    private void Start()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
        active = true;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        active = false;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
