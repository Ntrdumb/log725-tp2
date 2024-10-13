using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    [SerializeField] private GameObject redBulletPrefab;
    [SerializeField] private GameObject greenBulletPrefab;
    [SerializeField] private GameObject blueBulletPrefab; 
    [SerializeField] private Transform tankMuzzle; 

    private AmmoHandler _ammoHandler; 

    private void Start()
    {
        _ammoHandler = GetComponent<AmmoHandler>();  // Get AmmoHandler script attached to player
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) 
        {
            Shoot("red");
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Shoot("green");
        }
        else if (Input.GetKeyDown(KeyCode.C))  
        {
            Shoot("blue");
        }
    }

    private void Shoot(string ammoType)
    {
        // Check if the player has ammo in the AmmoHandler
        if (_ammoHandler != null)
        {
            switch (ammoType)
            {
                case "red":
                    if (_ammoHandler.GetAmmoCount("red") > 0)
                    {
                        _ammoHandler.UseAmmo("red");
                        AudioManager.Instance.PlayShootSound("red");
                        FireProjectile(redBulletPrefab);
                    }
                    break;
                case "green":
                    if (_ammoHandler.GetAmmoCount("green") > 0)
                    {
                        _ammoHandler.UseAmmo("green");
                        AudioManager.Instance.PlayShootSound("green");
                        FireProjectile(greenBulletPrefab);
                    }
                    break;
                case "blue":
                    if (_ammoHandler.GetAmmoCount("blue") > 0)
                    {
                        _ammoHandler.UseAmmo("blue");
                        AudioManager.Instance.PlayShootSound("blue");
                        FireProjectile(blueBulletPrefab);
                    }
                    break;
            }
        }
    }

    // Fire projectile in the direction the player is facing
    private void FireProjectile(GameObject bulletPrefab)
    {
        if (bulletPrefab != null && tankMuzzle != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, tankMuzzle.position, tankMuzzle.rotation);
            Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
            if (bulletRb != null)
            {
                bulletRb.AddForce(transform.right * 10f, ForceMode2D.Impulse);
            }
        }
    }
}
