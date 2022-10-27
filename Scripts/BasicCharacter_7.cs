using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharacter_7 : MonoBehaviour
{
    public Transform goal;
    public float speed = 0.1f;
    public float accuracy = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(goal.position);
        Vector3 direction = goal.position - transform.position;
        if(direction.magnitude > accuracy) {
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        Debug.DrawRay(transform.position,direction,Color.red);
    }
}
