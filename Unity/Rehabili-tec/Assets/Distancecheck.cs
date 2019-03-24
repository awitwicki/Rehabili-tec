using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distancecheck : MonoBehaviour
{
    public Transform head;
    public Transform hand;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(Vector2.Distance(head.position, hand.position));
        }
    }
}
