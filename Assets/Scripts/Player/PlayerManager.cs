using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static int numberOfCoins;
    public TextMeshProUGUI numberOfCoinsText;

    public static int currentHealth = 100;
    public Slider healthBar;

    public static bool gameOver;
    public static bool winLevel;

    public GameObject gameOverPanel;

    public float timer = 0;

    void Start()
    {
        numberOfCoins = 0;
        gameOver = winLevel = false;
    }

    void Update()
    {
        //Display the number of coins
        numberOfCoinsText.text = "coins:" + numberOfCoins;

        //Update the slider value
        healthBar.value = currentHealth;

        //game over
        if(currentHealth < 0)
        {
            gameOver = true;
            gameOverPanel.SetActive(true);
            currentHealth = 100;
        }

        if( FindObjectsOfType<Enemy>().Length ==0)
        {
            //Win Level
            winLevel = true;
            timer += Time.deltaTime;
            if(timer > 5)
            {
                int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
                if (nextLevel == 4)
                    SceneManager.LoadScene(0);

                if(PlayerPrefs.GetInt("ReachedLevel", 1) < nextLevel)
                    PlayerPrefs.SetInt("ReachedLevel", nextLevel);

                SceneManager.LoadScene(nextLevel);
            }

        }
    }
}
