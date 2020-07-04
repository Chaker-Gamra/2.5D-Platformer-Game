using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static int numberOfCoins;
    public TextMeshProUGUI numberOfCoinsText;

    public static int currentHealth = 100;
    public Slider healthBar;

    public static bool gameOver;

    void Start()
    {
        numberOfCoins = 0;//Reset the number of coins on each level
        gameOver = false;

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
        }
    }
}
