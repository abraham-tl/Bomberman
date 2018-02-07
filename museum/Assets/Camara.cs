﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public class ExampleClass : MonoBehaviour
    {
        Camera cam;

        void Start()
        {
            cam = GetComponent<Camera>();
        }

        void Update()
        {
            Ray ray = cam.ScreenPointToRay(new Vector3(200, 200, 0));
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
        }
    }
}