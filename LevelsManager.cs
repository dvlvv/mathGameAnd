using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{
    public Image cupImage1;
    public Image cupImage2;
    public Image cupImage3;
    public Image cupImage4;
    public GameObject levelMenu;

    private void Start()
    {
        cupImage1.gameObject.SetActive(false);
        cupImage2.gameObject.SetActive(false);
        cupImage3.gameObject.SetActive(false);
        cupImage4.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (levelMenu.activeSelf)
        {
            updateCupImage();
        }
    }

    private void updateCupImage()
    {
        switch (PlayerPrefs.GetInt("CurrentClass"))
        {
            case 1:
                if (PlayerPrefs.HasKey("1Class12"))
                {
                    cupImage1.gameObject.SetActive(true);
                }
                else cupImage1.gameObject.SetActive(false);
                break;
            case 2:
                if (PlayerPrefs.HasKey("2Class12"))
                {
                    cupImage2.gameObject.SetActive(true);
                }
                else cupImage2.gameObject.SetActive(false);
                break;
            case 3:
                if (PlayerPrefs.HasKey("3Class12"))
                {
                    cupImage3.gameObject.SetActive(true);
                }
                else cupImage3.gameObject.SetActive(false);
                break;
            case 4:
                if (PlayerPrefs.HasKey("4Class12"))
                {
                    cupImage4.gameObject.SetActive(true);
                }
                else cupImage4.gameObject.SetActive(false);
                break;
        }
    }


}
