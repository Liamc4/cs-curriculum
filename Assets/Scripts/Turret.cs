using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private float Cooldown = 2;
    public GameObject fireballPrefab;
    private GameObject player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       // print("ohit");
        if (other.gameObject.CompareTag("Player") )
        {
            player = other.gameObject;

        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        // print("ohit");
        if (other.gameObject.CompareTag("Player") )
        {
            player = null;

        }
    }


    // Update is called once per frame
    void Update()
    {
        Cooldown -= Time.deltaTime;

        if (player != null && Cooldown < 0)
        {
            Shoot();
        }


    }


    void Shoot()
    {
        GameObject clone = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
        //print(clone);
        Fireball script = clone.GetComponent<Fireball>();
        script.targetpos = player.transform.position;
        Cooldown = 2;
    }
}
