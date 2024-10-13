using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private AmmoHandler _ammoHandler;

    // Start is called before the first frame update
    private void Start()
    {
        // ammoHandler script
        _ammoHandler = GetComponent<AmmoHandler>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("redAmmo"))
        {
            _ammoHandler.AddAmmo("red", 1);  
            Destroy(collision.gameObject);  
        }
        else if (collision.CompareTag("greenAmmo"))
        {
            _ammoHandler.AddAmmo("green", 1); 
            Destroy(collision.gameObject);    
        }
        else if (collision.CompareTag("blueAmmo"))
        {
            _ammoHandler.AddAmmo("blue", 1);   
            Destroy(collision.gameObject);     
        }
    }
}
