using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<Vector3> waypoints;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
}
