using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonResponder : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI TextToChange;
    [SerializeField]
    private string Message = "Message";

    public void ButtonPressed ()
    {
        TextToChange.text = Message;
    }

}
