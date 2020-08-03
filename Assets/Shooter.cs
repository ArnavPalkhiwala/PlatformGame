using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public bool canShoot = true;
    public float timeBetweenShots = 1.0f;
    public float timeUntilNextShot;
    public int ammo = 30;
    public float reloadTime = 3.0f;
    public float timeToReloaded;
    public PlayerControls pc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeUntilNextShot)
        {
            canShoot = true;
        }
        if (Input.GetMouseButtonDown(0) && canShoot && pc.isDead == false)
        { 
            if(Input.GetButtonDown("Fire1") && canShoot && ammo > 0){
            
            ammo --;
            Debug.Log("Ammo: " + ammo);
            canShoot = false;
            timeUntilNextShot = Time.time + timeBetweenShots;
            Instantiate(bullet, this.transform.position, this.transform.rotation);
            if (ammo <= 0)
            {
                timeToReloaded = Time.time + reloadTime;
            }
        }
    }

    if (Time.time >= timeUntilNextShot)
    {
        canShoot = true;
    }

    if (Time.time >= timeToReloaded && ammo <= 0)
    {
        ammo = 30;
    }
    
    }
}
