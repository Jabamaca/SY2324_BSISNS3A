using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public delegate void OnPoolHandler (BulletController bullet);
    public OnPoolHandler OnPool = delegate {
    };

    public float Lifetime = 2f;
    private float _CurrentLifetime = 0f;

    public float Speed = 6f;

    // Update is called once per frame
    void Update () {
        float t = Time.deltaTime;
        _CurrentLifetime += t;
        transform.position += new Vector3 (Speed * t, 0f, 0f);

        if (_CurrentLifetime >= Lifetime) {
            gameObject.SetActive (false);
            OnPool (this);
        }
    }

    public void ResetObject () {
        _CurrentLifetime = 0f;
    }
}
