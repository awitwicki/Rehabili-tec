using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public void Destruction()
    {

    }

    IEnumerator Destruct()
    {

        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }

}
