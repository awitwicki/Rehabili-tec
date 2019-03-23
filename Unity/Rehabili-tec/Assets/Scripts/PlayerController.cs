using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Vector2 movDir;
    public ParticleSystem rewardSytem;

    private void Update()
    {
        movDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.Translate(movDir * Time.deltaTime * speed);
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
