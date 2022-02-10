using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.R)) ReloadCurrentScene();
   }

   public void LoadSceneByIndex(int index)
   {
      SceneManager.LoadScene(index);
   }

   public void ReloadCurrentScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
   
}
