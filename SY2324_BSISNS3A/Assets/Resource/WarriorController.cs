using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorController : MonoBehaviour
{
    public WarriorProperty Stats;

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(xInput, yInput, 0f).normalized;

        Vector3 movement = dir * (Stats.MovementSpeed * Time.deltaTime);
        transform.localPosition += movement;
    }
}
