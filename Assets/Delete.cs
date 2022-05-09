using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51f){
            Destroy(gameObject);
        }
    }
}
