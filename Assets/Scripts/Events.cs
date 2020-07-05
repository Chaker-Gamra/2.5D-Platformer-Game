using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    //replay level
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //quit game
    public void QuitGame()
    {
        Application.Quit();
    }
}
