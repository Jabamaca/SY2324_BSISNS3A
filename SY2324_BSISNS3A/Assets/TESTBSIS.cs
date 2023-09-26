using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTBSIS : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("I AM AWAKE");
    }

    private void OnEnable()
    {
        Debug.Log("I AM ENABLED");
    }

    private void OnDisable()
    {
        Debug.Log("I AM DISABLED");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("COMPONENT STARTED");
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1f;
        Vector3 transition = new Vector3(speed * Time.deltaTime, 0f, 0f);
        transform.localPosition += transition;
    }

    private void OnDestroy()
    {
        Debug.Log("I AM DESTROYED");
    }
}
