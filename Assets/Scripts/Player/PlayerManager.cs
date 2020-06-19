using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static int numberOfCoins;
    public TextMeshProUGUI numberOfCoinsText;

    void Start()
    {
        numberOfCoins = 0;//Reset the number of coins on each level
    }

    void Update()
    {
        //Display the number of coins
        numberOfCoinsText.text = "coins:" + numberOfCoins;
    }
}
