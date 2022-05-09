using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float speed = 25f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        if (Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction.x = touchPosition.x - transform.position.x;
            direction.y = touchPosition.y - transform.position.y + 5f;
            rb.velocity = new Vector2(direction.x, direction.y) * speed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;
        }
    }


    void OnCollisionEnter2D (){
        FindObjectOfType<GameManager>().EndGame();
    }
}
