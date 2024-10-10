using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcoins : MonoBehaviour
{
    public static Gamemanager gm;
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.gameObject.CompareTag("Coin"))
      {
          gm.AddScore(1);
            Destroy(other.gameObject);
            Debug.Log("Score: " + coins);
      }
    }
}
