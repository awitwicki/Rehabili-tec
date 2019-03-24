using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTriggerCheck : MonoBehaviour
{
    [HideInInspector]public bool active = false;
    private bool readyForAnotherCheck = false;
    private int lastSign = -1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "HeadT")
        {
            int currentSign = (int)Mathf.Sign(transform.position.y);
            Debug.Log("yay to działa");
            if(!readyForAnotherCheck)
                StartCoroutine(RotSession());

            if (readyForAnotherCheck && currentSign != lastSign)
            {
                StartCoroutine(SetActive());
                readyForAnotherCheck = false;
                lastSign = currentSign;
            }
           
        }
    }

    IEnumerator RotSession()
    {
        readyForAnotherCheck = true;
        yield return new WaitForSeconds(0.5f);
        readyForAnotherCheck = true;
    }

    IEnumerator SetActive()
    {
        active = true;
        yield return new WaitForSeconds(0.25f);
        active = false;
    }

}
