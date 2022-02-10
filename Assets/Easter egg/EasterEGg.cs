using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEGg : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(KillMe());
    }

    private IEnumerator KillMe()
    {
        yield return new WaitForSeconds(0.9f);
        Destroy(this.gameObject);
    }
}
