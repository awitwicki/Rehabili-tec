using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Platform")
        {
            other.GetComponent<PlatformPositionDetector>().PlayerIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Platform")
        {
            other.GetComponent<PlatformPositionDetector>().PlayerIn = false;
        }
    }
}
