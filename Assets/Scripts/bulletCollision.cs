using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class bulletCollision : MonoBehaviour
{
    [SerializeField] private string wallTag;

    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, 2000f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag(wallTag))
        {
            //UnityEngine.Debug.Log("wall: " + wallTag);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
