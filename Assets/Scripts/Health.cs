using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour

{
    //public float ftimer = 1;
    public int health;
    private Gamemanager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindFirstObjectByType<Gamemanager>();
    }

   private void OnCollisionEnter2D(Collision2D other)
    {
        print("collide");
            if (other.gameObject.CompareTag("Spikes"))
            {
                gm.ChangeHealth(-10);
            }

            
           /* if (other.gameObject.CompareTag("Enemy"))
            {
                gm.ChangeHealth(-20);
            }*/
    }

   private void OnTriggerEnter2D(Collider2D other)
   {
       if (other.gameObject.CompareTag("Fireball")) //&& (ftimer == 0))
       {
           //print("hcollide");
          // ftimer = 2;
          Destroy(other.gameObject);
           gm.ChangeHealth(- 5);
           
           
       }
   }


   // Update is called once per frame
    void Update()
    {
        //ftimer -= Time.deltaTime;
    }
}
