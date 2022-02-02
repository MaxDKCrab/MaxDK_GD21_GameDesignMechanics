using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceExplosion : MonoBehaviour
{
    [SerializeField] private Animator explosionAnim;
    [SerializeField] private float animationTime;
    [SerializeField] private float explosionForce;
    private GameObject player;
    private float distance;
    private Rigidbody2D playerRb;
    private Vector2 direction;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        Vector2 playerPos = player.transform.position;
        Vector2 explosionPos = transform.position;
        distance = Vector3.Distance(explosionPos, playerPos);
        direction = (playerPos - explosionPos).normalized;
        playerRb = player.GetComponent<Rigidbody2D>();
        StartCoroutine(Explode());
    }

    IEnumerator Explode()
    {
        
        explosionAnim.SetTrigger("Explode");
        yield return new WaitForSeconds(animationTime);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col == player) return;
        playerRb.AddForce(direction / distance * explosionForce);
    }
}
