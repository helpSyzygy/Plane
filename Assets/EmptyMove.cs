using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyMove : MonoBehaviour
{
    public Transform trans;
    public Rigidbody2D rb;
    private bool check;
    private Transform tr;

    public float speed = 2f;

    private float yMin, yMax;


    private void Start()
    {
        yMin = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).y + 1.25f;
        yMax = -yMin;
        check = false;
    }

    private void FixedUpdate()
    {
        if (trans.position.y >= yMax)
        {
            trans.position = new Vector3(trans.position.x, yMax);
            rb.velocity = new Vector2(0f, 0f);
            check = true;
        }
        else check = false;

        if (trans.position.y <= yMin)
        {
            trans.position = new Vector2(trans.position.x+0.565f, yMin + 0.565f);
        }
    }

    private void OnMouseDrag()
    {
        if (!check)
        {
            rb.velocity = Vector2.up * speed;
            //rb.velocity = Vector2.right * speed;
        }
    }
}
