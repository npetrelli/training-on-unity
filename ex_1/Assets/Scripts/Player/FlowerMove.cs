﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMove : MonoBehaviour
{
    Rigidbody2D rigidbody;
    
    float       thrust = 0.5f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(transform.up * -1.0f * thrust);
        if (gameObject.transform.position.y < Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y)
            Destroy(gameObject);
    }
}
