using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement_3 : MonoBehaviour
{
    
    public Transform goal;
    public float speed = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = goal.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
