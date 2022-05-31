using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject menuScreen;
    public GameObject congratsScreen;
    public GameObject correctAnswer;

    public void loadNextScreen()
    {
        correctAnswer.SetActive(false);
        menuScreen.SetActive(true);

        switch (PlayerPrefs.GetInt("CurrentClass"))
        {
            case 1:
                if (LevelsButtons1.isItTwelveLevel == true)
                {
                    correctAnswer.SetActive(false);
                    congratsScreen.SetActive(true);
                }
                else
                {
                    correctAnswer.SetActive(false);
                    menuScreen.SetActive(true);
                }
                break;
            case 2:
                if (LevelsButtons2.isItTwelveLevel == true)
                {
                    correctAnswer.SetActive(false);
                    congratsScreen.SetActive(true);
                }
                else
                {
                    correctAnswer.SetActive(false);
                    menuScreen.SetActive(true);
                }
                break;
            case 3:
                if (LevelsButtons3.isItTwelveLevel == true)
                {
                    correctAnswer.SetActive(false);
                    congratsScreen.SetActive(true);
                }
                else
                {
                    correctAnswer.SetActive(false);
                    menuScreen.SetActive(true);
                }
                break;
            case 4:
                if (LevelsButtons4.isItTwelveLevel == true)
                {
                    correctAnswer.SetActive(false);
                    congratsScreen.SetActive(true);
                }

                else
                {
                    correctAnswer.SetActive(false);
                    menuScreen.SetActive(true);
                }
                break;
        }
    }
}
