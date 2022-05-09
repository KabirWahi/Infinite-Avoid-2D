using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updelete : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 70f){
            Destroy(gameObject);
        }
    }
}
