using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour

{
    public int health;
    public Gamemanager gm;
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

            if (other.gameObject.CompareTag("Fireball"))
            {
                print("hcollide");
                gm.ChangeHealth(-20);
            }
            if (other.gameObject.CompareTag("Enemy"))
            {
                gm.ChangeHealth(-20);
            }
    }

   


    // Update is called once per frame
    void Update()
    {
        
    }
}
