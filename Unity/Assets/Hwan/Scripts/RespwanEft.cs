using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespwanEft : MonoBehaviour
{
    public Transform player;
    public Transform startPoiint;
    

    
    void Update()
    {
        if (Vector3.Distance(player.position, startPoiint.position) <= 0.5f)
        {
            Color color = gameObject.GetComponent<Material>().color;
            color = new Color(255f, 85f, 113f);
        }
    }
}
