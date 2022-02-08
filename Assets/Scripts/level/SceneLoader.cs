using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadSceneByIndex(int index)
   {
      SceneManager.LoadScene(index);
   }

   public void ReloadCurrentScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
   
}
