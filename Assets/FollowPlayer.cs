using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 camPos = transform.position - offset;
        Vector3 desiredPos = player.transform.position;
        Vector3 smoothedPos = Vector3.Lerp(camPos, desiredPos, 0.125f);
        
        transform.position = new Vector3(transform.position.x, smoothedPos.y, transform.position.z);
    }
}
