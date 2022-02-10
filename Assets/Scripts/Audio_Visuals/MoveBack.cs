using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
  //  [SerializeField] private GameObject Blob;
 
    [Range(-1f,1f)]  public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;
  
    void Start()
    {
        mat = GetComponent<Renderer>().material;
      
    }
    

    
    void Update()
    {
     
            offset += (Time.deltaTime * scrollSpeed) / 10;
            mat.SetTextureOffset("_MainTex", new Vector2(0, offset));
       
    }
}
