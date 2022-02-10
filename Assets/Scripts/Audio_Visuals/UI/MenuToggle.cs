using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MenuToggle : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    public void ToggleMenu()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        Cursor.visible = !Cursor.visible;
    }
    
}
