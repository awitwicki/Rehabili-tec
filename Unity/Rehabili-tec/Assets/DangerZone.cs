using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    public GameObject obstacle; 
    public Transform[] obstacleSpawnerTransforms;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
            StartCoroutine(SpawnObstacleWave());
    }

    public IEnumerator SpawnObstacleWave()
    {
        foreach (Transform t in obstacleSpawnerTransforms)
        {
            Instantiate(obstacle, t.position, Quaternion.identity);
            yield return null;
        }
    }
}
