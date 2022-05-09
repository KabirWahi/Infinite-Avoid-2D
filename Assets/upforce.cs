using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upforce : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force = new Vector2(0, 50);
        rb.AddForce(force);
    }
}
