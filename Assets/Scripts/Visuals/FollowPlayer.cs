using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
   // [SerializeField] private Vector3 offset;
    [SerializeField] private float maxPos;
    [SerializeField] private float minPos;
    private Vector3 desiredPos;
    private Vector3 position;
    private void Start()
    {
       // desiredPos = player.transform.position - offset;
        position = transform.position;
    }
    void Update()
    {
        // if (transform.position.y <= maxPos)
        // {
        //     position = new Vector3(position.x, desiredPos.y + 1f, position.z);
        //     transform.position = position;
        // }
        // else if (transform.position.y >= minPos)
        // { 
        //     position = new Vector3(position.x, desiredPos.y - 1f, position.z);
        //     transform.position = position;
        // }
        desiredPos = player.transform.position;
        desiredPos.y = Math.Clamp(desiredPos.y, minPos, maxPos);
        
        position = new Vector3(position.x,  desiredPos.y, position.z);
        // position.y = 
        transform.position = position;
    }
}
