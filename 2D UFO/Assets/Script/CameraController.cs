﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{

    public GameObject Main;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Main.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Main.transform.position + offset;
    }
    
}
