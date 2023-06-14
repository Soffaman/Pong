using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2 : MonoBehaviour
{
    Rigidbody2D myrigidbody2D;

    public bool isSimpleAIPlaying = false;
    public bool isHardAIPlaying = false;

    public Transform target;

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
        if (!isSimpleAIPlaying && !isHardAIPlaying)
        {
            float vertical = Input.GetAxisRaw("Vertical2");

            Vector2 move = new Vector2(0, vertical);

            myrigidbody2D.velocity = move * movementSpeed;
        }
        else if (isSimpleAIPlaying && !isHardAIPlaying)
        {
            SimpleAI();
        }
        else if (isHardAIPlaying && !isSimpleAIPlaying)
        {
            HardAI();
        }
        else
        {
            HardAI();
        }
    }

    private void HardAI()
    {
        float targetY = target.position.y;
        Vector3 newPosition = new Vector3(transform.position.x, targetY, 1);
        transform.position = Vector3.MoveTowards(transform.position, newPosition, movementSpeed * Time.deltaTime);
    }
    private void SimpleAI()
    {
        if(Mathf.Abs(this.transform.position.y - target.transform.position.y) > 50)
        {
            if (transform.position.y < target.transform.position.y)
            {
                myrigidbody2D.velocity = new Vector2(0, 1) * movementSpeed;
            }
            else
            {
                myrigidbody2D.velocity = new Vector2(0, -1) * movementSpeed;
            }
        }
        else
        {
            myrigidbody2D.velocity = new Vector2(0, 0);
        }
    }
}
