using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceExplosionController : MonoBehaviour
{
    public bool offCooldown = true;
    [SerializeField] private Transform player;
    [SerializeField] private GameObject forceExplosion;
    void Update()
    {
        
        
        
        if (Input.GetKeyDown(KeyCode.Mouse0) && offCooldown)
        {
            
            StartCoroutine(Explosion());
        }
        
    }

    IEnumerator Explosion()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = worldPosition;
        offCooldown = false;
        Instantiate(forceExplosion, transform);
        yield return new WaitForSeconds(1f);
        offCooldown = true;
    }
}
