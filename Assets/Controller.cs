﻿using System.Collections;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // What is the player doing with the controls?
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        // Update the bat position each frame
        transform.position += move * speed * Time.deltaTime;
    }
}
