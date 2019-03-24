using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public HandTriggerCheck[] hands = new HandTriggerCheck[2]; 

    public float speed;
    public Vector2 movDir;
    public ParticleSystem rewardSytem;

    private void Update()
    {
        if (hands[0].active)
        {
            movDir.x = -1;
        }


        if (hands[1].active)
        {
            movDir.x = 1;
        }

        if (!hands[0].active && !hands[1].active)
        {
            movDir.x = 0;
        }


       // movDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.Translate(movDir * Time.deltaTime * speed);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-7f,7f),-3.37f,0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Debug");
        if (collision.transform.tag == "Colectable")
        {
            Debug.Log("Debug");
            Destroy(collision.gameObject, 0.1f);
            GameManager.instance.ScoreCount++;
            rewardSytem.Play();
        }
    }
}
