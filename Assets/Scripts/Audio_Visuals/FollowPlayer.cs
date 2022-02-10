using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float maxPos;
    [SerializeField] private float minPos;
    private Vector3 desiredPos;
    private Vector3 position;
    private void Start()
    {
        position = transform.position;
    }
    void Update()
    {
        desiredPos = player.transform.position;
        desiredPos.y = Math.Clamp(desiredPos.y, minPos, maxPos);
        position = new Vector3(position.x,  desiredPos.y, position.z);
        transform.position = position;
    }
}
