using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject timerWindow;
    public bool win = false;
    private Rigidbody2D rb;
    
    private void FixedUpdate()
    {
        if (win)
        {
            Vector2 floatAway = player.transform.position;
            floatAway.y += 0.10f;
            rb.MovePosition(floatAway);
            winScreen.SetActive(true);
            timerWindow.SetActive(false);
            Cursor.visible = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col == player) return;

        rb = player.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.zero;
        win = true;


    }
}
