using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<Vector3> waypoints;
    private int num;
    public States state;
    public Vector3 target;
    private GameObject player;
    private float timer;
    private Gamemanager gm;
    public enum States
    {
        patrol,
        chase,
        attack,
        die
        
    }

    public TopDown_EnemyAnimator _controller;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<Gamemanager>();

        _controller = GetComponent<TopDown_EnemyAnimator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject;
            state = States.chase;
            timer = 8;
        }
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            target = player.transform.position;
        }

        if (state == States.patrol)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[num], 2 * Time.deltaTime);
            if (transform.position == waypoints[num])
            {
                num += 1;
                if (num > 2)
                {
                    num = 0;
                }
            }
        }

        if (state == States.chase)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                state = States.patrol;
            }

            transform.position = Vector3.MoveTowards(transform.position, target, 2 * Time.deltaTime);

        }


        

    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        state = States.attack;
        _controller.Attack();
        gm.ChangeHealth(-20);
        state = States.chase;
    }
}
