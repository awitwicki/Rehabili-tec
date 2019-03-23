using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPositionDetector : MonoBehaviour
{
    public MeshRenderer lightIndicator;
    private bool playerIn;
    public bool PlayerIn
    { get
        {
            return playerIn;
        }
      set
        {
            UpdateStatus(value);
            playerIn = value;
        }
    }

    private void UpdateStatus(bool status)
    {
        if (status)
        {
            Debug.Log("dziala", gameObject);
            lightIndicator.material.SetColor("_EmissionColor", Color.green);
        }
        else
            lightIndicator.material.SetColor("_EmissionColor", Color.red);
    }
}
