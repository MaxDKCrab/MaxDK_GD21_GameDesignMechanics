using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceImplosionController : MonoBehaviour
{
    public bool offCooldown = true;
    [SerializeField] private YouWin winScript;
    [SerializeField] private GameObject forceImplosion;

    private void Awake()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && offCooldown && !winScript.win)
        {
            StartCoroutine(Explosion());
        }
    }

    public IEnumerator Explosion()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = worldPosition;
        offCooldown = false;
        Instantiate(forceImplosion, transform);
        yield return new WaitForSeconds(1f);
        offCooldown = true;
    }
}

