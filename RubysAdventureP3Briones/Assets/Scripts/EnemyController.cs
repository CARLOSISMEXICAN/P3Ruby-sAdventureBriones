using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool verticle;
    public float changeTime = 3.0f;


    Rigidbody2D rigidbody2D;     
    float timer;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;

        if (verticle)
        {
            position.y = position.y + Time.deltaTime * speed;
        }
        else
        {

            position.x = position.x + Time.deltaTime * speed;
        }

        rigidbody2D.MovePosition(position);
    }

    void OnCollisioonEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController>();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
        
    }
}
