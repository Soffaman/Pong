using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2 : MonoBehaviour
{
    Rigidbody2D myrigidbody2D;

    public float movementSpeed = 5f;

    private void Awake()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        MoverVertical();
    }

    private void MoverVertical()
    {
        float vertical = Input.GetAxisRaw("Vertical2");

        Vector2 move = new Vector2(0, vertical);

        myrigidbody2D.velocity = move * movementSpeed;
    }
}
