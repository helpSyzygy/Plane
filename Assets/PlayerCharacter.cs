using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerCharacter : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 4f;
    public float force = 300f;
    public float rotateSpeed = 300f;
    public Transform target;
    public Rigidbody2D rbTarget;
    public Vector2 startPos;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = GetComponent<Transform>().position;
    }
    private void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.right).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.right * speed;

        transform.position = new Vector3(startPos.x, rb.transform.position.y, transform.position.z);

        target.position = new Vector2(transform.position.x + 4, target.position.y);



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
         
        }
        if (collision.gameObject.tag == "Level")
        {
            


        }
    }
}
