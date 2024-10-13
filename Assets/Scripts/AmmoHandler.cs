using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoHandler : MonoBehaviour
{
    [Header("Ammo Settings")]
    [SerializeField] private int redAmmo = 2; 
    [SerializeField] private int greenAmmo = 0;  
    [SerializeField] private int blueAmmo = 0;   

    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI redAmmoText;
    [SerializeField] private TextMeshProUGUI greenAmmoText;
    [SerializeField] private TextMeshProUGUI blueAmmoText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateAmmoUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UseAmmo(string ammoType)
    {
        switch (ammoType)
        {
            case "red":
                if (redAmmo > 0)
                {
                    redAmmo--;
                    UnityEngine.Debug.Log("Used Red Ammo. Remaining: " + redAmmo);
                    UpdateAmmoUI();
                }
                else
                {
                    UnityEngine.Debug.Log("No Red Ammo left!");
                }
                break;
            case "blue":
                if (blueAmmo > 0)
                {
                    blueAmmo--;
                    UnityEngine.Debug.Log("Used Blue Ammo. Remaining: " + blueAmmo);
                    UpdateAmmoUI();
                }
                else
                {
                    UnityEngine.Debug.Log("No Blue Ammo left!");
                }
                break;
            case "green":
                if (greenAmmo > 0)
                {
                    greenAmmo--;
                    UnityEngine.Debug.Log("Used Green Ammo. Remaining: " + greenAmmo);
                    UpdateAmmoUI();
                }
                else
                {
                    UnityEngine.Debug.Log("No Green Ammo left!");
                }
                break;
        }
    }

    public void AddAmmo(string ammoType, int amount)
    {
        switch (ammoType)
        {
            case "red":
                redAmmo += amount;
                UnityEngine.Debug.Log("Added Red Ammo. Total: " + redAmmo);
                UpdateAmmoUI();
                break;
            case "blue":
                blueAmmo += amount;
                UnityEngine.Debug.Log("Added Blue Ammo. Total: " + blueAmmo);
                UpdateAmmoUI();
                break;
            case "green":
                greenAmmo += amount;
                UnityEngine.Debug.Log("Added Green Ammo. Total: " + greenAmmo);
                UpdateAmmoUI();
                break;
        }
    }

    public int GetAmmoCount(string ammoType)
    {
        switch (ammoType)
        {
            case "red":
                return redAmmo;
            case "blue":
                return blueAmmo;
            case "green":
                return greenAmmo;
            default:
                return 0; 
        }
    }

    private void UpdateAmmoUI()
    {
        if (redAmmoText != null)
        {
            redAmmoText.text = redAmmo.ToString();
        }
        if (blueAmmoText != null)
        {
            blueAmmoText.text = blueAmmo.ToString();
        }
        if (greenAmmoText != null)
        {
            greenAmmoText.text = greenAmmo.ToString();
        }
    }
}
