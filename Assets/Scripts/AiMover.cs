using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMover : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;

    private void Update()
    {
        if (target != null)
        {
            float targetY = target.position.y;
            Vector2 newPosition = new Vector2(transform.position.x, targetY);
            transform.position = Vector2.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
        }
    }


}
