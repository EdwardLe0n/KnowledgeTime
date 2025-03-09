using TMPro;
using UnityEngine;

public class SunClicker : MonoBehaviour
{
    
    // Reference to the number of times the sun has been clicked
    public int clickCount;
    
    public TextMeshProUGUI textElement;

    private void Start()
    {
        clickCount = 0;
        updateText();
    }

    // Increases the sun click count by 1
    public void SunClick()
    {

        clickCount = clickCount + 1;
        updateText();

    }

    public void updateText()
    {
        textElement.text = clickCount.ToString();
    }
    

}
