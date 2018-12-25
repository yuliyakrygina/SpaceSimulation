using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

public class ButtonColor : MonoBehaviour

{
    private Button theButton;
    private ColorBlock theColor;

   
    void Awake()
    {
        theButton = GetComponent<Button>();
        theColor = GetComponent<Button>().colors;

    }

    public void ButtonTransitionColors()
    {
        theColor.normalColor = Color.green;
        theColor.highlightedColor = Color.green;
        theColor.pressedColor = Color.green;
        theButton.colors = theColor;

        print("Cliked");
    }
}
   
