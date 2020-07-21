using UnityEngine.UI;
using UnityEngine;

public class LevelsUnlock : MonoBehaviour
{
    public Button[] levelButtons;

    void Start()
    {
        foreach (Button b in levelButtons)
            b.interactable = false;

        int reachedLevel = PlayerPrefs.GetInt("ReachedLevel", 1);

        for (int i = 0; i < reachedLevel; i++)
            levelButtons[i].interactable = true;
    }

}
