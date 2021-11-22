using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonBehaviour : MonoBehaviour
{
    [SerializeField] ButtonType buttonType;

    public void ButtonClicked()
    {
        switch (buttonType)
        {
            case ButtonType.START:
                SceneManager.LoadScene("Game");
                break;
            case ButtonType.INSTRUCTIONS:
                SceneManager.LoadScene("Instructions");
                break;
            case ButtonType.MENU:
                SceneManager.LoadScene("Menu");
                break;
            case ButtonType.QUIT:
                Application.Quit();
                break;
        }

    }
}
