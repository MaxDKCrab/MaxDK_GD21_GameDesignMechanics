using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ExplosionIndicator : MonoBehaviour
{
   
    private void Start()
    {
       
        Cursor.visible = false;
       
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
       
    }
}
