using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    [SerializeField] ButtonType buttonType;

    public void ButtonClicked()
    {
        switch (buttonType)
        {
            case ButtonType.START:
                Debug.Log("Start");
                break;
            case ButtonType.INSTRUCTIONS:
                Debug.Log("Instructions");
                break;
            case ButtonType.QUIT:
                Debug.Log("Quit");
                break;
        }

    }
}
