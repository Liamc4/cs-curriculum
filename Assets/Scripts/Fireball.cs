using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private float timer;
    public Vector3 targetpos;
    // Start is called before the first frame update
    void Start()
    {
        timer = 2;
        Vector3.MoveTowards(transform.position, targetpos, maxDistanceDelta: 4 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0) 
        {
            Destroy(gameObject);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetpos, maxDistanceDelta: 4 * Time.deltaTime);
    }
}
