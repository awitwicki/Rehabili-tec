using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGen : MonoBehaviour
{
    public BoxCollider2D[] triggerAreas = new BoxCollider2D[4];
    public Vector2 generalOffset;
    public Vector2 tAreasOffset;
    public Vector2 tAreasSize;

    void Start()
    {
        for (int i = 0; i < 4; ++i)
        {
            triggerAreas[i] = gameObject.AddComponent<BoxCollider2D>();
            triggerAreas[i].size = tAreasSize;
            triggerAreas[i].offset = generalOffset;
            triggerAreas[i].isTrigger = true;
            switch (i)
            {
                case 0:
                    triggerAreas[0].offset += tAreasOffset;
                    break;
                case 1:
                    triggerAreas[1].offset += new Vector2(-tAreasOffset.x,tAreasOffset.y);
                    break;
                case 2:
                    triggerAreas[2].offset += new Vector2(tAreasOffset.x, -tAreasOffset.y);
                    break;
                case 3:
                    triggerAreas[3].offset += new Vector2(-tAreasOffset.x, -tAreasOffset.y);
                    break;
            }
        }
    }

}
