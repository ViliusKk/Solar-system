using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;

    void Update()
    {
        GetComponent<Transform>().Rotate(0f,speed,0f);
    }
}
