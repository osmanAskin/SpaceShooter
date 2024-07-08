using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform firePointTransform;
    [SerializeField] private GameObject BulletObject;

    public void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            Shoot();
        }

        /*
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        */
    }

    private void Shoot() 
    {
        //Shooting logic
        //Instantiate(BulletObject, firePointTransform.position, firePointTransform.rotation);
        GameObject bullet = ObjectPool.instance.GetPooledObject();  
        
        if(bullet != null) 
        {
            bullet.transform.position = firePointTransform.position;
            bullet.SetActive(true);
        }
    }


}
