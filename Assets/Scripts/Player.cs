using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D myrigidbody2D;

    float speed = 5f;

    private void Awake()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoverVertical();
    }

    private void MoverVertical()
    {
        float vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(0, vertical);

        myrigidbody2D.AddForce(move * speed);

    }
}
