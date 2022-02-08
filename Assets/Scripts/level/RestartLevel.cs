using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartLevel : MonoBehaviour
{
    public void RestartCurrentLevel()
    {
        SceneManager.LoadScene("Level 1");
    }
}
