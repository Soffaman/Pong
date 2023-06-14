using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    GameSession gameSession;

    Rigidbody2D rigidbody2D;

    [SerializeField]
    private float speed = 10;

    [SerializeField]
    private float VectorX = 2;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        rigidbody2D.AddForce(new Vector2(VectorX, 0) * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Gate1Player")
        {
            gameSession.IncresePlayer2();
            gameSession.ReloadScene();
        }
    }
}
