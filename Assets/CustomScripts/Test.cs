using NRKernal;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Test : MonoBehaviour /*, IPointerClickHandler*/
{
    public TextMeshProUGUI numberText;
    int counter = 0;

    public void ButtonPressed() {
        counter++;
        numberText.text = counter + "";
    }

    /*
    public void OnPointerClick(PointerEventData eventData)
    {
        counter++;
        numberText.text = counter + "";
        Debug.Log(counter);
    }
    */
}
