using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceExplosion : MonoBehaviour
{
    public bool offCooldown = true;
    [SerializeField] private Animator explosionAnim;
    
    void Update()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = worldPosition;
        if (Input.GetKeyDown(KeyCode.Mouse0) && offCooldown)
        {
            StartCoroutine(Explosion());

        }
        
    }

    IEnumerator Explosion()
    {
        offCooldown = false;
        explosionAnim.SetTrigger("Explode");
        yield return new WaitForSeconds(1f);
        offCooldown = true;
    }
}
