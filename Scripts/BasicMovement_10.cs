using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement_10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.name == "Cube" ) {
            GetComponent<Renderer>().material.color = Color.red;
            Data.puntuacion += 1;
            Debug.Log("Se ha chocado con " + this.name + " y la puntuación es " + Data.puntuacion);
        }
    }
}
