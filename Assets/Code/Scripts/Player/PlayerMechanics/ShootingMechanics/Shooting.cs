using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private PauseMenu _pMenu;

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(CooldownCo());
        }
            
           
    }
    private IEnumerator CooldownCo()
    {
        Shoot();
        yield return new WaitForSeconds(3f);    
    }
    void Shoot()
    {
        AudioManager.audioMReference.PlaySFX(5);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
