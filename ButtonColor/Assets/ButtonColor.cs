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
    public bool isGreen;
    public bool isRed;

   
    void Awake()
    {
        theButton = GetComponent<Button>();
        theColor = GetComponent<Button>().colors;

    }

    public void ButtonTransitionColor()
    {
        if (isGreen)
        {
            //theColor.normalColor = Color.green;
            theColor.highlightedColor = Color.green;
            //theColor.pressedColor = Color.green;
            theButton.colors = theColor;

            print("Clicked");
        }

        if (isRed)
        {
            theColor.highlightedColor = Color.red;
            //theColor.pressedColor = Color.red;
            theButton.colors = theColor;

            print("Clicked");
        }
    }

  
   
}
   
