using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float speed; 
    void Start()
    {
        speed = Random.Range(10f, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*Time.deltaTime*speed);
    }
}
