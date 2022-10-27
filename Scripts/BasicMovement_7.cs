using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement_7 : MonoBehaviour
{
    //public Transform goal;
    public float speed = 0.1f;
    //public float accuracy = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
   
        Vector3 posicion = new Vector3 (transform.position.x + (h * speed * Time.deltaTime), 0.55f, transform.position.z + (v * speed * Time.deltaTime));
        transform.position = posicion;
        
    }
}
