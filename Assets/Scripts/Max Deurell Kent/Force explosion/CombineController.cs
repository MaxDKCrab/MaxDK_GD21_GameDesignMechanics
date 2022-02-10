using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineController : MonoBehaviour
{
    public bool offCooldown = true;
    [SerializeField] private YouWin winScript;
    [SerializeField] private GameObject forceExplosion;
    [SerializeField] private GameObject forceImplosion;
    [SerializeField] private float cooldown;
    
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

        if (Input.GetKeyDown(KeyCode.Mouse1) && offCooldown && !winScript.win)
        {
            StartCoroutine(Implosion());
        }
    }

    public IEnumerator Explosion()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = worldPosition;
        offCooldown = false;
        Instantiate(forceExplosion, transform);
        yield return new WaitForSeconds(cooldown);
        offCooldown = true;
    }
    
    public IEnumerator Implosion()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = worldPosition;
        offCooldown = false;
        Instantiate(forceImplosion, transform);
        yield return new WaitForSeconds(cooldown);
        offCooldown = true;
    }
}
