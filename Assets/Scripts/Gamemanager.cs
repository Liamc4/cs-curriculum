using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    public int coins;
    public static Gamemanager gm;
    public int health = 100;
    public int Max_Health = 100;

    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI HealthText;
    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        CoinText.text = "Coins: " + coins;
        HealthText.text = "Health: " + health;
    }
    

    public void AddScore(int i)
    {
        coins += 1;
        CoinText.text = "Coins: " + coins;
    }

    private int getHealth()
    {
        return health;
    }

    public void ChangeHealth(int amount)
    {
        health += amount;
        if (health > Max_Health)
        {
            health = Max_Health;
        }

        HealthText.text = "Health: " + health;
        if (health < 1)
        {
            Die();
        }
    }

    void Die()
    {
        //print("ya dead");
        gm.health = 100;
        gm.coins = 0;
        CoinText.text = "Coins: " + coins;
        HealthText.text = "Health: " + health;
        SceneManager.LoadScene(0);
        
    }
    

    void AM_coins()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
