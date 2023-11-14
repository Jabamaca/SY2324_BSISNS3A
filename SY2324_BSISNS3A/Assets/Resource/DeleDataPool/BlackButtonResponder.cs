using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackButtonResponder : MonoBehaviour {

    [SerializeField]
    List<int> InList = new List<int> ();
    [SerializeField]
    int[] IntArray = new int[5];
    [SerializeField]
    Dictionary<string, int> IntDict = new Dictionary<string, int> ();

    [SerializeField]
    ButtonController Button;

    private void Start () {
        InList.Add (4);
        InList.Add (14);
        InList.Add (-100);
        InList.Add (7);

        foreach (int x in InList) {
            Debug.Log (x.ToString ());
        }

        InList.Sort ();

        foreach (int x in InList) {
            Debug.Log (x);
        }

        IntDict["firepower"] = 0;
        Debug.Log (IntDict["firepower"]);
    }

    private void OnEnable () {
        Button.OnClick += ButtonResponse;
    }

    private void OnDisable () {
        Button.OnClick -= ButtonResponse;
    }

    private void ButtonResponse () {
        Debug.Log ("I AM UI CONTROLLER");
    }
}