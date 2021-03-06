using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    [SerializeField]
    GameObject bulletFire;

    [SerializeField]
    float timer = 1f;

    bool canFire = true;

    private void Awake()
    {
        
    }

    IEnumerator Fire()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canFire)
        {
            canFire = false;

            GameObject bullet = Instantiate(bulletFire, transform.position, transform.rotation);

            yield return new WaitForSeconds(0.3f);

            canFire = true;
        }

    }

    private void Update()
    {
        StartCoroutine("Fire");
    }
}
