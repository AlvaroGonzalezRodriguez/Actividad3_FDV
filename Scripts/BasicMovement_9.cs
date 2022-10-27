using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement_9 : MonoBehaviour
{

    public float speed = 0.1f;
    public float turn = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.name);
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
   
        Vector3 posicion = new Vector3 (transform.position.x + (h * speed * Time.deltaTime), transform.position.y , transform.position.z + (v * speed * Time.deltaTime));
        transform.position = posicion;

        if (Input.GetKeyDown("space")) {
            speed = speed * 2;
            turn = turn * 2;
        }

        float r = Input.GetAxisRaw("Rotate");
        transform.Rotate(r * Vector3.up * turn * Time.deltaTime);
    }
}
