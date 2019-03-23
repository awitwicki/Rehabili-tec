using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeLineTrigger : MonoBehaviour
{
    public UnityEvent OnEnableEvent;

    private void OnEnable()
    {
        OnEnableEvent.Invoke();
    }
}
