using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    public delegate void OnClickResponder ();
    public OnClickResponder OnClick = delegate {
    };

    private void OnMouseDown () {
        Debug.Log ("Clicked");
        OnClick ();
    }
}