using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelsManager1 : MonoBehaviour
{
    [SerializeField] private bool unlocked;

    public Image lockImage;
    public Sprite lockedSprite;
    public Sprite unlockedSprite;
    public Button levelButton;
    public int currentLevel;
    public GameObject Menu;

    private void Update()
    {
        if (Menu.activeSelf)
        {
            UpdateLevelImage();
            UpdateLevelStatus();
        }
    }


    private void UpdateLevelImage()
    {
        switch (unlocked) 
        {
            case true:  // проверка разблокированного уровня и удаление иконки замка
                lockImage.GetComponent<Image>().sprite = unlockedSprite;
                levelButton.interactable = true;
                if (PlayerPrefs.GetInt("1Class" + currentLevel) == 1)
                {
                    lockImage.gameObject.SetActive(false);
                }
                break;
            case false: // проверка заблокированного уровня и устанвка иконки замка
                lockImage.GetComponent<Image>().sprite = lockedSprite;
                levelButton.interactable = false;
                break;
        }
    }

    private void UpdateLevelStatus()
    {
        int prevLevel = int.Parse(gameObject.name) - 1;
        if (PlayerPrefs.GetInt("1Class" + prevLevel.ToString()) == 1)
        {
            unlocked = true;
        }
    }
}
