using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEasterEgg : MonoBehaviour
{
    [SerializeField] private GameObject troll;
    private bool easterEggCd = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && easterEggCd == false) StartCoroutine(GetTrolled());
    }

    private IEnumerator GetTrolled()
    {
        easterEggCd = true;
        Instantiate(troll, transform);
        yield return new WaitForSeconds(1f);
        easterEggCd = false;
    }
}
