using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater350 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 350f * Time.deltaTime, 0, Space.Self);
    }
}
