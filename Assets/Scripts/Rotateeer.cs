using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateeer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 250f * Time.deltaTime, 0, Space.Self);
    }
}
